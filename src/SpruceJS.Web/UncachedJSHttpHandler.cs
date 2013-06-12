using System;
using System.IO;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class UncachedJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/javascript";

			// no-cache
			context.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
			context.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
			context.Response.AppendHeader("Expires", "0"); // Proxies.

			// Output
			context.Response.Write(File.ReadAllText(context.Request.PhysicalPath));
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
