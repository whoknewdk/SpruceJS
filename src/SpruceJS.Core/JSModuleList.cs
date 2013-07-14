using System.Collections;
using System.Collections.Generic;
using SpruceJS.Core.Sort;

namespace SpruceJS.Core
{
	public class JSModuleList : IEnumerable<JSModule>
	{
		private readonly IDictionary<string, JSModule> modules = new Dictionary<string, JSModule>();

		public int Count { get { return modules.Count; } }

		public void Add(JSModule module)
		{
			if (module != null)
				modules.Add(module.Name, module);
		}

		public IEnumerator<JSModule> GetEnumerator()
		{
			return SortingService.Sort(modules).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
