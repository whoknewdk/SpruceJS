using System.IO;
using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.IO;
using SpruceJS.Core.Modules.Exceptions;
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
				var builder = new WebSpruceBuilder(null, new FileSystem()) { Minify = true };

				string actualPath = filePath.Replace(".spruce.js", ".js");

				// Load JavaScript or JSON config
				if (File.Exists(context.Server.MapPath(actualPath)))
					builder.LoadModule(actualPath);
				else
					builder.LoadConfig(filePath.Replace(".spruce.js", ".spruce.json"));

				// Build everything and get output
				var output = builder.GetOutput();

				// Save SourceMap for next request
				context.Application[filePath + ".map"] = output.SourceMapBody;

				// Write JavaScript
				context.Response.Write(output.JavaScriptBody);
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
