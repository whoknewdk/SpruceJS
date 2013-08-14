using System.Web;
using SpruceJS.Core.Config;
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
	}
}
