using System.Collections;
using System.Collections.Generic;
using SpruceJS.Core.Sort;

namespace SpruceJS.Core
{
	public class JSModuleList : IEnumerable<JSModule>
	{
		private readonly IList<JSModule> modules = new List<JSModule>();

		public int Count { get { return modules.Count; } }

		public void Add(JSModule module)
		{
			if (module != null)
				modules.Add(module);
		}

		public IEnumerator<JSModule> GetEnumerator()
		{
			return SortingService.Sort(modules, x => x.Name, x => x.Dependencies).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
