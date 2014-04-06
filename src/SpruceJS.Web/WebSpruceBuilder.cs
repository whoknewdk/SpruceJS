using System.Web;
using SpruceJS.Core;

namespace SpruceJS.Web
{
	public class WebSpruceBuilder : SpruceBuilder
	{
		readonly HttpContext context = HttpContext.Current;

		public WebSpruceBuilder() : base()
		{
			ModuleRootPath = context.Request.PhysicalApplicationPath;
		}

		public new void LoadJS(string jsFilePath)
		{
			base.LoadJS(context.Server.MapPath(jsFilePath));
		}

		public new void LoadConfig(string jsonConfigPath)
		{
			base.LoadConfig(context.Server.MapPath(jsonConfigPath));
		}
	}
}
