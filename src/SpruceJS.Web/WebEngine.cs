using System.IO;
using System.Web;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine, IEngine
	{
		readonly HttpContext context;

		public WebEngine(IFileConfig fileConfig, ContentLoader loader, HttpContext context)
			: base(fileConfig, loader)
		{
			this.context = context;
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}

		public static IEngine Create(string configFilePath, HttpContext context)
		{
			var config = new WebSpruceConfig(new HttpContextWrapper(context));
			config.Load(configFilePath);

			var fileConfig = new FileConfig(config, Path.GetDirectoryName(context.Server.MapPath(configFilePath)), context.Request.PhysicalApplicationPath);

			// Create engine instance
			return new WebEngine(fileConfig, new ContentLoader(), context);
		}
	}
}
