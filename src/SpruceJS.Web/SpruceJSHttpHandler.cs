using System.IO;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;
			string sourceMapFile = filePath + ".map";
			string configFilePath = filePath.Replace(".spruce.js", ".config");

			var config = new WebAppConfig(configFilePath, context);

			// Create engine instance
			var engine = new WebEngine(config, context);

			// no-cache
			context.Response.ContentType = "text/javascript";
			context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
			context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
			context.Response.AppendHeader("Expires", "0"); // Proxies.

			// Get result
			var result = engine.Render(filePath);

			// Save sourcemap to disk
			File.WriteAllText(sourceMapFile, result.SourceMap);

			context.Response.AppendHeader("X-SourceMap", sourceMapFile);
			context.Response.Write(result.Content);
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
