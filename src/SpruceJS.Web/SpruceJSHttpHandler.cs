﻿using System.IO;
using System.Web;
using System.Web.SessionState;

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

			var config = new WebAppConfig(configFilePath, context);

			// Create engine instance
			var engine = new WebEngine(config, context, Path.GetDirectoryName(context.Server.MapPath(configFilePath)), context.Request.PhysicalApplicationPath);
			engine.Minify = SpruceJSConfigurationSection.Instance.Minify;

			// Get result
			var result = engine.Render(filePath);

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

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
