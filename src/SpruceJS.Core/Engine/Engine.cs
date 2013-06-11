using System.IO;
using SpruceJS.Core.Config;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		JSApp app;
		IAppConfig config;

		public Engine(IAppConfig config)
		{
			app = new JSApp(new AjaxminMinificator("app.spruce.js"));
			this.config = config;
		}

		public void loadDirectoryFiles(string path, bool isRecursive)
		{
			DirectoryInfo info = new DirectoryInfo(path);
			
			foreach (var file in info.GetFiles())
				app.Add(createModule(file.FullName));
			
			foreach (var directory in info.GetDirectories())
				loadDirectoryFiles(directory.FullName, isRecursive);
		}

		public EngineResult Render()
		{
			// Add files
			foreach (var file in config.Files)
				app.Add(createModule(file));

			// Add directory files
			foreach (var directory in config.Directories)
				loadDirectoryFiles(directory.Path, directory.Recursive);

			return new EngineResult { Output = app.ToString(), SourceMap = app.SourceMap };
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}

		private JSModule createModule(string filePath)
		{
			string fullPath = GetFullPath(filePath);

			// Stop if no file exists
			if (!File.Exists(fullPath))
				return null;

			// Read/Analyse file
			string content = File.ReadAllText(fullPath);
			var fileAnalyzer = new JSFileAnalyzer(content);

			// Stop if content is not valid
			if (!fileAnalyzer.IsValid) 
				return null;

			var info = new FileInfo(fullPath);

			// Build new module
			return new JSModule {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
				Content = content,

				FileName = info.Name
			};
		}
	}
}
