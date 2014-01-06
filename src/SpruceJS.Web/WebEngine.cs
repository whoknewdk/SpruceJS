using System.IO;
using System.Web;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine
	{
		readonly HttpContext context;


		public WebEngine(string filePath, IContentLoader loader, HttpContext context)
			: base(filePath, loader)
		{
			this.context = context;
		}

		public WebEngine(IFileConfig fileConfig, IContentLoader loader, HttpContext context, bool includeScript) : base(fileConfig, loader, includeScript)
		{
			this.context = context;
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}

		public static IEngine CreateFile(string filePath, HttpContext context)
		{
			// Create engine instance
			return new WebEngine(filePath, new ContentLoader(context.Request.PhysicalApplicationPath, Path.GetDirectoryName(filePath)), context);
		}

		public static IEngine Create(string configFilePath, HttpContext context)
		{
			var config = new WebSpruceConfig(new HttpContextWrapper(context));
			config.Load(configFilePath);

			var loader = new ContentLoader(context.Request.PhysicalApplicationPath, Path.GetDirectoryName(context.Server.MapPath(configFilePath)));
			var fileConfig = new FileConfig(config, loader);

			// Create engine instance
			return new WebEngine(fileConfig, loader, context, config.IncludeScript);
		}
	}
}
