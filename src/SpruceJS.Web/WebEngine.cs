using System.Web;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine, IEngine
	{
		HttpContext context;

		public WebEngine(IAppConfig appConfig, HttpContext context)
			: base(appConfig)
		{
			this.context = context;
		}

		protected override string GetFullPath(string path)
		{
			return context.Server.MapPath(path);
		}
	}
}
