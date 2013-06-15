using System.IO;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			var config = new WebAppConfig(context.Request.FilePath.Replace(".spruce.js", ".config"), context);

			// Create engine instance
			var engine = new WebEngine(config, context);

			// no-cache
			context.Response.ContentType = "text/javascript";
			context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
			context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
			context.Response.AppendHeader("Expires", "0"); // Proxies.

			// Output
			var result = engine.Render();
			context.Response.AppendHeader("X-SourceMap", result.SourceMap);
			context.Response.Write(result.Output);
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
