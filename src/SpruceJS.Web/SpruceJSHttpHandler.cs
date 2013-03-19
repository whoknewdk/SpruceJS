using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpruceJS.Web
{
	public class SpruceJSHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
