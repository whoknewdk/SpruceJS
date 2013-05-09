using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSModuleList : IEnumerable<JSModule>
	{
		private IDictionary<string, JSModule> modules = new Dictionary<string, JSModule>();

		public int Count { get { return modules.Count; } }

		public void Add(JSModule module)
		{
			if (module != null)
				modules.Add(module.Name, module);
		}

		public IEnumerator<JSModule> GetEnumerator()
		{
			foreach (JSModule module in SortingService.Sort<JSModule>(modules))
				yield return module;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (JSModule module in SortingService.Sort<JSModule>(modules))
				yield return module;
		}
	}
}
