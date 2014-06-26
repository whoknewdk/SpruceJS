using SpruceJS.Core;
using SpruceJS.Core.IO;
using System.Web;

namespace SpruceJS.Web
{
	public class WebSpruceBuilder : SpruceBuilder
	{
		readonly HttpContext context = HttpContext.Current;

		public WebSpruceBuilder(IFileSystem fileSystem) : base(fileSystem)
		{
			ModuleRootPath = context.Request.PhysicalApplicationPath;
		}

		public new void LoadModule(string path)
		{
			base.LoadModule(context.Server.MapPath(path));
		}

		public new void LoadConfig(string path)
		{
			base.LoadConfig(context.Server.MapPath(path));
		}
	}
}
