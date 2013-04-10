using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Core
{
	public class Engine
	{
		JSApp app = new JSApp();

		public Engine(IAppConfig config)
		{
			// Add files
			foreach (var file in config.Files)
				app.Add(create(file));

			// Add directory files
			foreach (var dir in config.Directories)
			{
				DirectoryInfo info = new DirectoryInfo(dir.Path);
				foreach (var file in info.GetFiles())
					app.Add(create(file.FullName));
			}
		}

		public string Render()
		{
			return app.ToString();
		}

		private JSModule create(string filePath)
		{
			// Stop if no file exists
			if (!File.Exists(filePath))
				return null;

			// Read/Analyse file
			string content = File.ReadAllText(filePath);
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
