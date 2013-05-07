using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private IDictionary<string, JSModule> Modules = new Dictionary<string, JSModule>();

		public void Add(JSModule module)
		{
			if (module != null)
				Modules.Add(module.Name, module);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (JSModule module in SortingService.Sort(Modules))
				sb.Append(module.Content);

			return sb.ToString();
		}

		public int Count
		{
			get { return Modules.Count; }
		}
	}
}
