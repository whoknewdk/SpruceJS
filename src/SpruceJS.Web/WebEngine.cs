using System.Web;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web
{
	public class WebEngine : Engine, IEngine
	{
		readonly HttpContext context;

		public WebEngine(ISpruceConfig appConfig, HttpContext context, string configDirectoryPath, string projectDirectoryPath)
			: base(appConfig, configDirectoryPath, projectDirectoryPath)
		{
			this.context = context;
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}
	}
}
