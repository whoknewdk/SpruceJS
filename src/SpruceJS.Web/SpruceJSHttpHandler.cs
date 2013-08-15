using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.Exceptions;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IRequiresSessionState, IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;

			// Output SourceMap
			context.Response.ContentType = "text/javascript";
			if (filePath.Contains(".map"))
			{
				context.Response.Write(context.Application[filePath]);
				return;
			}

			// Output JavaScript
			string configFilePath = filePath.Replace(".spruce.js", ".spruce.config").Replace(".map", "");

			try
			{
				var engine = WebEngine.Create(configFilePath, context);
				engine.Minify = SpruceJSConfigurationSection.Instance.Minify;

				// Get result
				var result = engine.GetOutput();

				context.Application[filePath + ".map"] = result.SourceMapBody;

				// no-cache
				if (!SpruceJSConfigurationSection.Instance.Cache)
				{
					context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
					context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
					context.Response.AppendHeader("Expires", "0"); // Proxies.	
				}
				context.Response.AppendHeader("X-SourceMap", filePath + ".map");
				context.Response.Write(result.JavaScriptBody);
			}
			catch (SpruceException ex)
			{
				context.Response.Write("throw '" + ex.Message + "';");
			}
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
