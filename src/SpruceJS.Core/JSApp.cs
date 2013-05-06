using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSApp
	{
		public IDictionary<string, JSModule> Modules = new Dictionary<string, JSModule>();

		public void Add(JSModule module)
		{
			if (module != null)
				Modules.Add(module.Name, module);
		}

		public override string ToString()
		{
			List<JSModule> list = new List<JSModule>();

			// Topological sort
			foreach (var m in Modules.Values)
				if (!m.Marked)
					visit(m, list);

			var sb = new StringBuilder();
			foreach (JSModule module in list)
				sb.Append(module.Content);

			return sb.ToString();
		}

		public void visit(JSModule module, List<JSModule> list)
		{
			if (module.TempMarked)
				throw new Exception("Not DAG exception");

			if (!module.Marked) {
				module.TempMarked = true;

				foreach (string name in module.Dependencies)
					visit(Modules[name], list);

				module.TempMarked = false;
				module.Marked = true;

				// mark perm
				list.Add(module);
			}
		}
	}
}
