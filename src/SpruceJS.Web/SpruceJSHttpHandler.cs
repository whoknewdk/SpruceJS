using System.Web;
using System.Web.SessionState;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IRequiresSessionState, IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;
			string map = filePath + ".map";

			// no-cache
			context.Response.ContentType = "text/javascript";
			context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
			context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
			context.Response.AppendHeader("Expires", "0"); // Proxies.

			if (filePath.Contains(".map"))
			{
				context.Response.Write(context.Session[map]);
				context.Session.Remove(map);
			}
			else
			{
				string configFilePath = filePath.Replace(".spruce.js", ".spruce.config");

				var config = new WebAppConfig(configFilePath, context);

				// Create engine instance
				var engine = new WebEngine(config, context);

				// Get result
				var result = engine.Render(filePath);

				// Save source map for sibling request
				context.Session[map] = result.SourceMapBody;

				context.Response.AppendHeader("X-SourceMap", map);
				context.Response.Write(result.JavaScriptBody);
			}
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
