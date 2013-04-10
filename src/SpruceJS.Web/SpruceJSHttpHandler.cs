using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SpruceJS.Core;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			// Read config
			var configFile = context.Server.MapPath("app.config");
			var config = new WebAppConfig(configFile, context);

			// Create engine instance
			var engine = new Engine(config);

			// Output 
			context.Response.Write(engine.Render());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
