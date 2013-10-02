using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Exceptions.Modules;
using SpruceJS.Core.Exceptions.Sort;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Visitor;

namespace SpruceJS.Core.Engine
{
	public enum ModuleMode
	{
		Amd = 0,
		CommonJS = 1
	}

	public class Engine : IEngine
	{
		readonly Regex regex = new Regex(Regex.Escape("define("));
		HashSet<string> keys = new HashSet<string>();

		readonly SpruceApplication app = new SpruceApplication(new AjaxminMinifier());

		public bool Minify { get; set; }
		public bool ExcludeJsLib { get; set; }
		public ModuleMode Mode { get; set; }

		private readonly string filePath;
		private readonly IFileConfig fileConfig;
		private readonly IContentLoader loader;

		public Engine(string filePath, IContentLoader loader)
		{
			this.filePath = filePath;
			this.loader = loader;

			Mode = ModuleMode.CommonJS;
		}

		public Engine(IFileConfig fileConfig, IContentLoader loader)
		{
			this.fileConfig = fileConfig;
			this.loader = loader;

			Mode = ModuleMode.CommonJS;
		}

		public IOutput GetOutput()
		{
			if (fileConfig != null)
			{
				// Add externals
				foreach (var externalFile in fileConfig.Externals)
					app.AddExternal(createExternal(externalFile));

				var dependencies = new HashSet<string>();

				// Add files
				foreach (var file in fileConfig.Files)
				{
					var module = createModule(file);
					app.AddModule(module);

					// Store keys and dependencies
					keys.Add(module.Name);
					foreach (var d in module.Dependencies)
						dependencies.Add(d);
				}

				// Try to locate module on disk
				fetchModulesOnDisk(dependencies.Except(keys));
			}
			else
			{
				var module = createModule(filePath, "demo1/main");
				module.Content = regex.Replace(module.Content, String.Format("define('{0}',", module.Name), 1);
				app.AddModule(module);
				fetchModulesOnDisk(module.Dependencies);
			}

			try
			{
				// Minify?
				if (Minify)
					return app.GetMinifiedOutput();

				return new EngineOutput {
					JavaScriptBody = app.GetOutput()
				};
			}
			catch (NameNotFoundException<ModuleItem> ex)
			{
				throw new ModuleKeyDoesNotExistException(ex.Name, ex.Item.Url);
			}
			catch (NotDirectedAcyclicGraphException<ModuleItem> ex)
			{
				throw new ModuleKeyCircularReferenceException(ex.Items.Select(x => x.Url).ToArray());
			}
		}

		private void fetchModulesOnDisk(IEnumerable<string> unfoundDependencies)
		{
			foreach (var unfoundDependency in unfoundDependencies)
			{
				var fileOnDisk = loader.GetFullPath(unfoundDependency.Replace("/", "\\") + ".js");
				if (File.Exists(fileOnDisk))
				{
					var module = createModule(fileOnDisk);
					module.Name = unfoundDependency;
					module.Content = regex.Replace(module.Content, String.Format("define('{0}',", module.Name), 1);

					app.AddModule(module);

					// Add
					keys.Add(module.Name);
					fetchModulesOnDisk(module.Dependencies.Except(keys));
				}
			}
		}

		private ModuleItem createModule(string filePath, string name)
		{
			string content = loader.GetContent(filePath);

			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
			SpruceVisitor moduleVisitor = new CommonJsVisitor();
			if (Mode == ModuleMode.Amd)
				moduleVisitor = new AmdVisitor();

			moduleVisitor.Load(content);

			// Stop if content is not valid
			if (!moduleVisitor.IsValid)
				throw new ModuleNotValidException(filePath);

			// Build new module
			return new ModuleItem(name, moduleVisitor.Dependencies)
			{
				Content = content,
				Url = UrlPath(filePath)
			};
		}

		private ModuleItem createModule(string filePath)
		{
			string content = loader.GetContent(filePath);
			
			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
			SpruceVisitor moduleVisitor = new CommonJsVisitor();
			if (Mode == ModuleMode.Amd)
				moduleVisitor = new AmdVisitor();

			moduleVisitor.Load(content);

			// Stop if content is not valid
			if (!moduleVisitor.IsValid)
				throw new ModuleNotValidException(filePath);

			// If no name exists, use path
			string name = moduleVisitor.Indentifier;

			// Build new module
			return new ModuleItem(name, moduleVisitor.Dependencies) {
				Content = content,
				Url = UrlPath(filePath)
			};
		}

		private ExternalItem createExternal(string filePath)
		{
			string content = loader.GetContent(filePath);

			// Stop if no file exists
			if (content == null)
				return null;

			// Build new module
			return new ExternalItem
			{
				Content = content,
				Url = UrlPath(filePath)
			};
		}

		protected virtual string UrlPath(string path)
		{
			return path;
		}

		public static IEngine Create(string configFilePath, string projecyDirPath)
		{
			var config = new SpruceConfig();
			config.Load(configFilePath);

			var loader = new ContentLoader(Path.GetDirectoryName(configFilePath), projecyDirPath);
			var fileConfig = new FileConfig(config, loader);
			return new Engine(fileConfig, loader);
		}
	}
}
