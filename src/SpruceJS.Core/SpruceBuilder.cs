﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Content.Exceptions;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Sort.Exceptions;
using SpruceJS.Core.Visitor;

namespace SpruceJS.Core
{
	public class SpruceBuilder : IBuilder
	{
		readonly Regex regex = new Regex(Regex.Escape("define("));
		HashSet<string> keys = new HashSet<string>();

		readonly SpruceApplication app = new SpruceApplication(new AjaxminMinifier());

		public bool Minify { get; set; }

		private readonly string filePath;
		private readonly IFileConfig fileConfig;
		private readonly IContentLoader loader;

		// Single file entry constructor
		public SpruceBuilder(string filePath, IContentLoader loader)
		{
			this.filePath = filePath;
			this.loader = loader;
		}

		// Config file entry contructor
		public SpruceBuilder(IFileConfig fileConfig, IContentLoader loader, bool includeScript)
		{
			this.fileConfig = fileConfig;
			this.loader = loader;
			app.IncludeScript = includeScript;
		}
		public SpruceBuilder(IFileConfig fileConfig, IContentLoader loader)
			: this(fileConfig, loader, true) { }

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
					var module = createModule(file, trimToName(UrlPath(file)));
					app.AddModule(module);

					if (module == null) 
						continue;

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
				var module = createModule(filePath, trimToName(UrlPath(filePath)));
				app.AddModule(module);

				if (module != null)
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

		private string trimToName(string name)
		{
			return name.Substring(1).Replace(".spruce.js", "").Replace(".js", "");
		}

		private void fetchModulesOnDisk(IEnumerable<string> unfoundDependencies)
		{
			foreach (var unfoundDependency in unfoundDependencies)
			{
				var fileOnDisk = loader.GetFullPathForKey(unfoundDependency.Replace("/", "\\") + ".js");
				if (File.Exists(fileOnDisk))
				{
					var module = createModule(fileOnDisk, unfoundDependency);
					app.AddModule(module);

					if (module == null)
						continue;

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
			var moduleVisitor = new ModuleVisitor();

			moduleVisitor.Load(content);

			// Stop if content is not valid
			if (!moduleVisitor.IsValid)
				throw new ModuleNotValidException(filePath);

			string n = moduleVisitor.Indentifier ?? name;
			string c = moduleVisitor.Indentifier != null
				                 ? content
				                 : regex.Replace(content, String.Format("define('{0}',", n), 1);
			string url = UrlPath(filePath);

			// Build new module
			return new ModuleItem(url, c, n, moduleVisitor.Dependencies);
		}

		private ExternalItem createExternal(string filePath)
		{
			string content = loader.GetContent(filePath);

			// Stop if no file exists
			if (content == null)
				return null;

			string url = UrlPath(filePath);

			// Build new module
			return new ExternalItem(url, content);
		}

		protected virtual string UrlPath(string path)
		{
			return path;
		}

		public static IBuilder Create(string configFilePath, string projecyDirPath)
		{
			var config = new SpruceConfig();
			config.Load(configFilePath);

			var loader = new ContentLoader(projecyDirPath, Path.GetDirectoryName(configFilePath));
			var fileConfig = new FileConfig(config, loader);
			return new SpruceBuilder(fileConfig, loader, config.IncludeScript);
		}
	}
}