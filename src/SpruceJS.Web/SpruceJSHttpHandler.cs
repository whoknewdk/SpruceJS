using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			// Read config
			var configFile = context.Server.MapPath("app.config");
			var config = new AppConfig(configFile);

			// Create engine instance
			var engine = new WebEngine(config, context);

			// Output 
			context.Response.Write(engine.Render());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
