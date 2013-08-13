using System.Web;
using SpruceJS.Core.Config;

namespace SpruceJS.Web
{
	public class WebAppConfig : SpruceConfig, ISpruceConfig
	{
		HttpContext context;

		public WebAppConfig(string path, HttpContext context)
		{
			this.context = context;
			Load(path);
		}

		protected override string GetFullPath(string path)
		{
			return context.Server.MapPath(path);
		}
	}
}
