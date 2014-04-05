using System.IO;
using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.Modules.Exceptions;
using SpruceJS.Core.Script;
using SpruceJS.Web.WebConfig;

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
			if (filePath.Contains("spruce-define.js"))
			{
				context.Response.Write(SpruceLib.Body);
				return;
			}

			try
			{
				var builder = new WebSpruceBuilder {
					Minify = SpruceJSConfigurationSection.Instance.Minify
				};

				string actualPath = filePath.Replace(".spruce.js", ".js");

				// Load JavaScript or JSON config
				if (File.Exists(context.Server.MapPath(actualPath)))
					builder.LoadJS(actualPath);
				else
					builder.LoadConfig(filePath.Replace(".spruce.js", ".spruce.json"));

				// Get result
				var result = builder.GetOutput();

				// Save SourceMap for next request
				context.Application[filePath + ".map"] = result.SourceMapBody;

				// Write JavaScript
				context.Response.Write(result.JavaScriptBody);
			}
			catch (SpruceModuleException ex)
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
