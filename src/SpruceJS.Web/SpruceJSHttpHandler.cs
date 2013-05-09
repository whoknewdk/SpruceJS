using System.IO;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			var config = new WebAppConfig("app.config", context);

			// Create engine instance
			var engine = new WebEngine(config, context);

			// Output
			context.Response.ContentType = "text/javascript";
			context.Response.Write(engine.Render());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
