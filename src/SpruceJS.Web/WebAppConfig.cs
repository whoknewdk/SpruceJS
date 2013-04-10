using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class WebAppConfig : AppConfig, IAppConfig
	{
		public WebAppConfig(string config, HttpContext context) : base(config)
		{
		}
	}
}
