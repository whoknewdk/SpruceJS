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

		public bool Minify { get; set; }

		private readonly IAppConfig config;
		private readonly string configDirectoryPath;
		private readonly string projectDirectoryPath;
		public Engine(IAppConfig config, string configDirectoryPath, string projectDirectoryPath)
		{
			this.config = config;
			this.configDirectoryPath = configDirectoryPath;
			this.projectDirectoryPath = projectDirectoryPath;
		}

		public IResult Render()
		{
			var fileConfig = new FileConfig(config, GetFullPath);

			// Add files
			foreach (var file in fileConfig.Files)
				app.Add(createModule(file));

			// Minify?
			if (Minify)
				return app.GetMinifiedOutput();

			return new EngineResult {
				JavaScriptBody = app.GetOutput()
			};
		}

		private string GetFullPath(string path)
		{

			if (path.StartsWith("\\"))
			{
				string pathWithoutBeginnningSlash = path.Substring(1, path.Length - 1);
				return Path.GetFullPath(Path.Combine(projectDirectoryPath, pathWithoutBeginnningSlash));
			}

			return Path.GetFullPath(Path.Combine(configDirectoryPath, path));
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
