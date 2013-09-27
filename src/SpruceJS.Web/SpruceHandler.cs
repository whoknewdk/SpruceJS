using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Exceptions;
using SpruceJS.Core.Script;

namespace SpruceJS.Web
{
	public class SpruceHandler : IRequiresSessionState, IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;

			// Response Headers
			context.Response.ContentType = "text/javascript";
			context.Response.AppendHeader("X-SourceMap", filePath + ".map");
			
			// no-cache
			if (!SpruceJSConfigurationSection.Instance.Cache)
			{
				context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
				context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
				context.Response.AppendHeader("Expires", "0"); // Proxies.	
			}
			context.Response.Flush();

			// Output SourceMap
			if (filePath.Contains(".map"))
			{
				context.Response.Write(context.Application[filePath]);
				return;
			}

			// Spruce library
			if (filePath.Contains("spruce-define.spruce.js"))
			{
				context.Response.Write(SpruceLib.Body);
				return;
			}

			try
			{
				string configFilePath = filePath.Replace(".spruce.js", ".spruce.json");
				var engine = WebEngine.Create(configFilePath, context);
				engine.Minify = SpruceJSConfigurationSection.Instance.Minify;
				engine.Mode = ModuleMode.CommonJS;

				// Get result
				var result = engine.GetOutput();

				// Save SourceMap for next request
				context.Application[filePath + ".map"] = result.SourceMapBody;

				// Write JavaScript
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
