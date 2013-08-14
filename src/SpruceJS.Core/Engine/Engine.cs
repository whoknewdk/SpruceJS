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
		public bool ExcludeJsLib { get; set; }

		private readonly IFileConfig fileConfig;
		private readonly IContentLoader loader;

		public Engine(IFileConfig fileConfig, IContentLoader loader)
		{
			this.fileConfig = fileConfig;
			this.loader = loader;
		}

		public IResult Render()
		{
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

		private ModuleItem createModule(string filePath)
		{
			string content = loader.GetContent(filePath);
			
			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
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
	}
}
