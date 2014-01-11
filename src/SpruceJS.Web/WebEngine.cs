using System.IO;
using System.Web;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;

namespace SpruceJS.Web
{
	public class WebSpruceBuilder : SpruceBuilder
	{
		readonly HttpContext context;


		public WebSpruceBuilder(string filePath, IContentLoader loader, HttpContext context)
			: base(filePath, loader)
		{
			this.context = context;
		}

		public WebSpruceBuilder(IFileConfig fileConfig, IContentLoader loader, HttpContext context, bool excludeScript)
			: base(fileConfig, loader, excludeScript)
		{
			this.context = context;
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}

		public static IBuilder CreateFile(string filePath, HttpContext context)
		{
			// Create engine instance
			return new WebSpruceBuilder(filePath, new ContentLoader(context.Request.PhysicalApplicationPath, Path.GetDirectoryName(filePath)), context);
		}

		public static IBuilder Create(string configFilePath, HttpContext context)
		{
			var config = new WebSpruceConfig(new HttpContextWrapper(context));
			config.Load(configFilePath);

			var loader = new ContentLoader(context.Request.PhysicalApplicationPath, Path.GetDirectoryName(context.Server.MapPath(configFilePath)));
			var fileConfig = new FileConfig(config, loader);

			// Create engine instance
			return new WebSpruceBuilder(fileConfig, loader, context, !config.IncludeScript);
		}
	}
}
