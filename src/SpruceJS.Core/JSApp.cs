using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private JSModuleList Modules = new JSModuleList();

		public void Add(JSModule module)
		{
			Modules.Add(module);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			foreach (JSModule module in Modules)
				sb.Append(module.Content);

			return sb.ToString();
		}

		public int Count
		{
			get { return Modules.Count; }
		}
	}
}
