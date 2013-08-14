using System.Collections;
using System.Collections.Generic;
using SpruceJS.Core.Content;
using SpruceJS.Core.Sort;

namespace SpruceJS.Core.Content
{
	public class ModuleItemList : IEnumerable<ModuleItem>
	{
		private readonly IList<ModuleItem> modules = new List<ModuleItem>();

		public void Add(ModuleItem module)
		{
			if (module != null)
				modules.Add(module);
		}

		public IEnumerator<ModuleItem> GetEnumerator()
		{
			return TopSort.Sort(modules, x => x.Name, x => x.Dependencies).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
