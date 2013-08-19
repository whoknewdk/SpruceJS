using System.IO;
using System.Linq;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Exceptions.Modules;
using SpruceJS.Core.Exceptions.Sort;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		readonly SpruceApplication app = new SpruceApplication(new AjaxminMinifier());

		public bool Minify { get; set; }
		public bool ExcludeJsLib { get; set; }

		private readonly IFileConfig fileConfig;
		private readonly IContentLoader loader;

		public Engine(IFileConfig fileConfig, IContentLoader loader)
		{
			this.fileConfig = fileConfig;
			this.loader = loader;
		}

		public IOutput GetOutput()
		{
			// Add externals
			foreach (var externalFile in fileConfig.Externals)
				app.AddExternal(createExternal(externalFile));

			// Add files
			foreach (var file in fileConfig.Files)
				app.AddModule(createModule(file));

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

		private ModuleItem createModule(string filePath)
		{
			string content = loader.GetContent(filePath);
			
			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
			var fileAnalyzer = new AMDStructureAnalyzer(content);

			// Stop if content is not valid
			if (!fileAnalyzer.IsValid) 
				return null;

			// Build new module
			return new ModuleItem {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
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

			var fileConfig = new FileConfig(config, Path.GetDirectoryName(configFilePath), projecyDirPath);
			return new Engine(fileConfig, new ContentLoader());
		}
	}
}
