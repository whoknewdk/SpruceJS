using System.IO;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Results;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		readonly JSApp app = new JSApp(new AjaxminMinificator());

		private readonly IAppConfig config;
		public Engine(IAppConfig config)
		{
			this.config = config;
		}

		public IResult Render(string appName)
		{
			var fileConfig = new FileConfig(config, GetFullPath);

			// Add files
			foreach (var file in fileConfig.Files)
				app.Add(createModule(file));

			// Minify?
			if (SpruceJSConfigurationSection.Instance.Minify)
				return app.GetMinifiedOutput(appName);

			return new EngineResult {
				JavaScriptBody = app.GetOutput(appName)
			};
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}

		private JSModule createModule(string filePath)
		{
			// Stop if no file exists
			if (!File.Exists(filePath))
				return null;

			// Read/Analyse file
			string content = File.ReadAllText(filePath);
			var fileAnalyzer = new JSFileAnalyzer(content);

			// Stop if content is not valid
			if (!fileAnalyzer.IsValid) 
				return null;

			// Build new module
			return new JSModule {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
				Content = content,

				Url = UrlPath(filePath)
			};
		}

		protected virtual string UrlPath(string path)
		{
			return path;
		}
	}
}
