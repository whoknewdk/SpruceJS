using System.Collections.Generic;
using SpruceJS.Core.Combiner;
using SpruceJS.Core.Content;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Script;

namespace SpruceJS.Core
{
	public class SpruceApplication
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		public bool IncludeScript { get; set; }

		readonly ICombiner combiner;
		public SpruceApplication(ICombiner combiner)
		{
			this.combiner = combiner;
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
			// Included js lib
			if (IncludeScript)
				combiner.Add(SpruceLib.Body, "spruce-define.spruce.js");

			// Add externals
			foreach (var external in externals)
				combiner.Add(external.Content, external.Url);

			// Add modules
			foreach (var module in modules)
				combiner.Add(module.Content, module.Url);

			return combiner.GetOutput();
		}
	}
}
