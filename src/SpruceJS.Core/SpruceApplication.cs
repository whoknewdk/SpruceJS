using System.Collections.Generic;
using System.Text;
using SpruceJS.Core.Content;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Script;

namespace SpruceJS.Core
{
	public class SpruceApplication
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		public bool IncludeScript { get; set; }

		readonly IMinifier minifier;
		public SpruceApplication(IMinifier minifier)
		{
			this.minifier = minifier;
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

		public EngineOutput GetMinifiedOutput()
		{
			minifier.Clear();

			// Included js lib
			if (IncludeScript)
				minifier.Add(SpruceLib.Body, "spruce-define.spruce.js");

			// Add externals
			foreach (var external in externals)
				minifier.Add(external.Content, external.Url);

			// Add modules
			foreach (var module in modules)
				minifier.Add(module.Content, module.Url);

			return minifier.Minify();
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
