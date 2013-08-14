using System;
using System.IO;
using System.Web;
using System.Web.SessionState;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Exceptions;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IRequiresSessionState, IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string filePath = context.Request.FilePath;

			context.Response.ContentType = "text/javascript";
			if (filePath.Contains(".map"))
			{
				context.Response.Write(context.Application[filePath]);
				return;
			}

			string configFilePath = filePath.Replace(".spruce.js", ".spruce.config").Replace(".map", "");

			var config = new WebSpruceConfig(new HttpContextWrapper(context));
			config.Load(configFilePath);

			try
			{
				var fileConfig = new FileConfig(config, Path.GetDirectoryName(context.Server.MapPath(configFilePath)), context.Request.PhysicalApplicationPath);
				var loader = new ContentLoader();

				// Create engine instance
				var engine = new WebEngine(fileConfig, loader, context);
				engine.Minify = SpruceJSConfigurationSection.Instance.Minify;

				// Get result
				var result = engine.Render();

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
