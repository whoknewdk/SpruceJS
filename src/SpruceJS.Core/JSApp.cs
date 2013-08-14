using System.Collections.Generic;
using System.Text;
using SpruceJS.Core.Content;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Script;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		readonly IMinifier minificator;
		public JSApp(IMinifier minificator)
		{
			this.minificator = minificator;
		}

		public void AddModule(ModuleItem module)
		{
			modules.Add(module);
		}

		public void AddExternal(ExternalItem external)
		{
			externals.Add(external);
		}

		public MinifyResult GetMinifiedOutput()
		{
			return minificator.Minify(modules, externals);
		}

		public string GetOutput()
		{
			// Read embedded JavaScript library
			var sb = new StringBuilder(SpruceLib.Body);

			foreach (var external in externals)
				sb.Append(external.Content);

			foreach (var module in modules)
				sb.Append(module.Content);
			
			return sb.ToString();
		}
	}
}
