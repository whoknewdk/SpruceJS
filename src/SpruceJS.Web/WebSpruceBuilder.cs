using System.Web;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;

namespace SpruceJS.Web
{
	public class WebSpruceBuilder : SpruceBuilder
	{
		readonly HttpContext context = HttpContext.Current;

		public WebSpruceBuilder() : base()
		{
		}
		public WebSpruceBuilder(IFileConfig fileConfig, IContentLoader loader) : base(fileConfig, loader)
		{
		}

		public void LoadJS(string jsFilePath)
		{
			LoadJS(mapPath(jsFilePath), context.Request.PhysicalApplicationPath);
		}

		public void LoadConfig(string jsonConfigPath)
		{
			LoadConfig(mapPath(jsonConfigPath), context.Request.PhysicalApplicationPath);
		}

		protected override string UrlPath(string path)
		{
			return "/" + path.Replace(context.Request.PhysicalApplicationPath, "").Replace("\\", "/");
		}

		private string mapPath(string path)
		{
			return context.Server.MapPath(path);
		}
	}
}
