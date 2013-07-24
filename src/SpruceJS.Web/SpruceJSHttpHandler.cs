using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IRequiresSessionState, IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;

			// no-cache
			if (!SpruceJSConfigurationSection.Instance.Cache)
			{
				context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
				context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
				context.Response.AppendHeader("Expires", "0"); // Proxies.	
			}

			string configFilePath = filePath.Replace(".spruce.js", ".spruce.config").Replace(".map", "");

			var config = new WebAppConfig(configFilePath, context);

			// Create engine instance
			var engine = new WebEngine(config, context);

			// Get result
			var result = engine.Render(filePath);

			context.Response.ContentType = "text/javascript";
			if (filePath.Contains(".map"))
			{
				context.Response.Write(result.SourceMapBody);
			}
			else
			{
				context.Response.AppendHeader("X-SourceMap", filePath + ".map");
				context.Response.Write(result.JavaScriptBody);
			}
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
