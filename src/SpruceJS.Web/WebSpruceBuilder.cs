using System.IO;
using System.Web;
using SpruceJS.Core;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;

namespace SpruceJS.Web
{
	public class WebSpruceBuilder : SpruceBuilder
	{
		readonly HttpContext context = HttpContext.Current;

		public WebSpruceBuilder(string filePath, IContentLoader loader)
			: base(filePath, loader)
		{
			
		}

		public WebSpruceBuilder(IFileConfig fileConfig, IContentLoader loader)
			: base(fileConfig, loader)
		{
			
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}

		public static IBuilder CreateFile(string JsfilePath)
		{
			var context = HttpContext.Current;
			string mappedPath = context.Server.MapPath(JsfilePath);

			// Create engine instance
			string directoryName = Path.GetDirectoryName(mappedPath);
			var loader = new ContentLoader(context.Request.PhysicalApplicationPath, directoryName);
			return new WebSpruceBuilder(mappedPath, loader);
		}

		public static IBuilder Create(string jsonConfigPath)
		{
			var context = HttpContext.Current;

			var config = new SpruceConfig();
			config.Load(context.Server.MapPath(jsonConfigPath));

			string directoryName = Path.GetDirectoryName(context.Server.MapPath(jsonConfigPath));
			var loader = new ContentLoader(context.Request.PhysicalApplicationPath, directoryName);
			var fileConfig = new FileConfig(config, loader);

			// Create engine instance
			return new WebSpruceBuilder(fileConfig, loader) {
				ExcludeScript = !config.IncludeScript
			};
		}
	}
}
