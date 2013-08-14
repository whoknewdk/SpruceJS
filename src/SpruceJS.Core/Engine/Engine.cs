﻿using System.IO;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Results;

namespace SpruceJS.Core.Engine
{
	public class Engine : IEngine
	{
		readonly JSApp app = new JSApp(new AjaxminMinifier());

		public bool Minify { get; set; }

		private readonly ISpruceConfig config;
		private readonly string configDirectoryPath;
		private readonly string projectDirectoryPath;
		public Engine(ISpruceConfig config, string configDirectoryPath, string projectDirectoryPath)
		{
			this.config = config;
			this.configDirectoryPath = configDirectoryPath;
			this.projectDirectoryPath = projectDirectoryPath;
		}

		public IResult Render()
		{
			var fileConfig = new FileConfig(config, GetFullPath);

			// Add externals
			foreach (var externalFile in fileConfig.Externals)
				app.AddExternal(createExternal(externalFile));

			// Add files
			foreach (var file in fileConfig.Files)
				app.AddModule(createModule(file));

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
				return Path.Combine(projectDirectoryPath, pathWithoutBeginnningSlash);
			}

			return Path.Combine(configDirectoryPath, path);
		}

		private ModuleItem createModule(string filePath)
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
			return new ModuleItem {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
				Content = content,
				Url = UrlPath(filePath)
			};
		}

		private ExternalItem createExternal(string filePath)
		{
			// Stop if no file exists
			if (!File.Exists(filePath))
				return null;

			// Read/Analyse file
			string content = File.ReadAllText(filePath);

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
	}
}
