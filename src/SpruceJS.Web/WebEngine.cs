using System.Web;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine, IEngine
	{
		public WebEngine(IAppConfig appConfig, HttpContext context)
			: base(appConfig)
		{
			
		}
	}
}
