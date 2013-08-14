using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class WebSpruceConfig : SpruceConfig, ISpruceConfig
	{
		readonly HttpContextBase context;

		public WebSpruceConfig(HttpContextBase context)
		{
			this.context = context;
		}

		protected override string GetFullPath(string path)
		{
			return context.Server.MapPath(path);
		}
	}
}
