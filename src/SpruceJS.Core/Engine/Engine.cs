using System.IO;
using SpruceJS.Core.Config;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		readonly JSApp app = new JSApp(new AjaxminMinificator());

		readonly IAppConfig config;
		public Engine(IAppConfig config)
		{
			this.config = config;
		}

		private void loadDirectoryFiles(string path, bool isRecursive)
		{
			var info = new DirectoryInfo(path);
			
			foreach (var file in info.GetFiles())
				app.Add(createModule(file.FullName));

			// Stop, if not recursive
			if (!isRecursive) 
				return;

			foreach (var directory in info.GetDirectories())
				loadDirectoryFiles(directory.FullName, true);
		}

		public EngineResult Render(string appName)
		{
			// Add files
			foreach (var file in config.Files)
				app.Add(createModule(GetFullPath(file)));

			// Add directory files
			foreach (var directory in config.Directories)
				loadDirectoryFiles(GetFullPath(directory.Path), directory.Recursive);

			MinifyResult result = app.GetBuild(appName);

			return new EngineResult {
				Content = result.Content, 
				SourceMap = result.SourceMap 
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

			var fi = new FileInfo(filePath);

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
