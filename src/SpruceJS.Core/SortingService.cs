using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public static class SortingService
	{
		// Topological sort
		public static List<JSModule> Sort(IDictionary<string, JSModule> Modules)
		{
			List<JSModule> list = new List<JSModule>();

			// Topological sort
			foreach (var m in Modules.Values)
				if (!m.Marked)
					visit(m, list, Modules);

			return list;
		}

		public static void visit(JSModule module, List<JSModule> list, IDictionary<string, JSModule> Modules)
		{
			if (module.TempMarked)
				throw new Exception("Not DAG exception");

			if (!module.Marked)
			{
				module.TempMarked = true;

				foreach (string name in module.Dependencies)
					visit(Modules[name], list, Modules);

				module.TempMarked = false;
				module.Marked = true;

				// mark perm
				list.Add(module);
			}
		}
	}
}
