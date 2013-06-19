using System.Web;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine, IEngine
	{
		readonly HttpContext context;

		public WebEngine(IAppConfig appConfig, HttpContext context)
			: base(appConfig)
		{
			this.context = context;
		}

		protected override string GetFullPath(string path)
		{
			return context.Server.MapPath(path);
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}
	}
}
