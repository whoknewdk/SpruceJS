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

			context.Response.ContentType = "text/javascript";

			// no-cache
			context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
			context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
			context.Response.AppendHeader("Expires", "0"); // Proxies.

			var result = engine.Render();

			// Output
			context.Response.AppendHeader("X-SourceMap", result.SourceMap);
			//context.Response.Write("function define (x, y, z) { z(); }" + "\n");
			context.Response.Write(result.Output + "\n");
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
