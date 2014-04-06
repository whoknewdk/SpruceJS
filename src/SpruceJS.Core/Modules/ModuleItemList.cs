using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Modules.Exceptions;
using SpruceJS.Core.Sort;

namespace SpruceJS.Core.Modules
{
	public class ModuleItemList : IEnumerable<ModuleItem>
	{
		private readonly HashSet<ModuleItem> modules = new HashSet<ModuleItem>();

		public void Add(ModuleItem module)
		{
			if (module != null)
				modules.Add(module);
		}

		public void AddRange(IEnumerable<ModuleItem> moduleItems)
		{
			foreach (var m in moduleItems)
				modules.Add(m);
		}

		public IEnumerator<ModuleItem> GetEnumerator()
		{
			// Throw exception if duplicate keys exist
			string[] duplicateKeys = modules.GroupBy(x => x.Name).Where(x => x.Count() > 1 && !String.IsNullOrEmpty(x.Key)).Select(x => x.Key).ToArray();
			if (duplicateKeys.Length > 0)
			{
				string[] urls = modules.Where(x => duplicateKeys.Contains(x.Name)).Select(x => x.Url).ToArray();
				throw new ModuleKeyNotUniqueException(duplicateKeys, urls);
			}

			return TopSort.Sort(modules, x => x.Name, x => x.Dependencies).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
