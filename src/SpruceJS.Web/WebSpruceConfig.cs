using System.IO;
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

		protected override string GetFullPathContent(string path)
		{
			return File.ReadAllText(context.Server.MapPath(path));
		}
	}
}
