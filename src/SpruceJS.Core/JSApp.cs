using SpruceJS.Core.Minification;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private readonly JSModuleList modules = new JSModuleList();

		readonly IMinificator minificator;
		public JSApp(IMinificator minificator)
		{
			this.minificator = minificator;
		}

		public void Add(JSModule module)
		{
			modules.Add(module);
		}

		public MinifyResult GetBuild(string appName)
		{
			return minificator.Minify(modules, appName);
		}
	}
}
