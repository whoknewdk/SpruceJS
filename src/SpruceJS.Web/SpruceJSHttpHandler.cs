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
			context.Response.AddHeader("X-SourceMap", "/app.spruce.js.map");
			context.Response.Write("function define (x, y, z) { z(); }" + "\n");
			context.Response.Write(engine.Render() + "\n");
			//context.Response.Write("//@ sourceMappingURL=/app.spruce.js.map");
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
