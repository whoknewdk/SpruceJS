using System.Collections.Generic;
using System.Text;
using SpruceJS.Core.Content;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Script;

namespace SpruceJS.Core
{
	public class SpruceApplication
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		public bool IncludeScript { get; set; }

		readonly IMinifier minificator;
		public SpruceApplication(IMinifier minificator)
		{
			this.minificator = minificator;
			IncludeScript = true;
		}

		public void AddModule(ModuleItem module)
		{
			modules.Add(module);
		}

		public void AddExternal(ExternalItem external)
		{
			externals.Add(external);
		}

		public MinifyOutput GetMinifiedOutput()
		{
			return minificator.Minify(modules, externals, IncludeScript);
		}

		public string GetOutput()
		{
			var sb = new StringBuilder();

			// Read embedded JavaScript library
			if (IncludeScript)
				sb.Append(SpruceLib.Body);

			foreach (var external in externals)
				sb.Append(external.Content);

			foreach (var module in modules)
				sb.Append(module.Content);
			
			return sb.ToString();
		}
	}
}
