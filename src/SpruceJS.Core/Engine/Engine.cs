using System.IO;
using SpruceJS.Core.Config;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		JSApp app = new JSApp();

		public Engine(IAppConfig config)
		{
			// Add files
			foreach (var file in config.Files)
				app.Add(create(file));

			// Add directory files
			foreach (var directory in config.Directories)
				loadDirectoryFiles(directory.Path, directory.Recursive);
		}

		public void loadDirectoryFiles(string path, bool isRecursive)
		{
			DirectoryInfo info = new DirectoryInfo(path);
			
			foreach (var file in info.GetFiles())
				app.Add(create(file.FullName));
			
			foreach (var directory in info.GetDirectories())
				loadDirectoryFiles(directory.FullName, isRecursive);
		}

		public string Render()
		{
			return app.ToString();
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}

		private JSModule create(string filePath)
		{
			// Stop if no file exists
			if (!File.Exists(filePath))
				return null;

			// Read/Analyse file
			string content = File.ReadAllText(GetFullPath(filePath));
			var fileAnalyzer = new JSFileAnalyzer(content);

			// Stop if content is not valid
			if (fileAnalyzer.IsValid) 
				return null;

			// Build new module
			return new JSModule {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
				Content = content
			};
		}
	}
}
