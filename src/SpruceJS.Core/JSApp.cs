using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private JSModuleList Modules = new JSModuleList();

		public string SourceMap;

		IMinificator minificator;
		public JSApp(IMinificator minificator)
		{
			this.minificator = minificator;
			SourceMap = this.minificator.SourceMap;
		}

		public void Add(JSModule module)
		{
			Modules.Add(module);
		}

		public override string ToString()
		{
			//var sb = new StringBuilder();

			Dictionary<string, string> lst = new Dictionary<string,string>();

			foreach (JSModule module in Modules)
				lst.Add(module.FileName, module.Content);

			//foreach (JSModule module in Modules)
			//	sb.Append(minificator.Minify(module.Content, module.FileName));

			//minificator.Close();

			return minificator.Minify(lst);
		}

		public int Count
		{
			get { return Modules.Count; }
		}
	}
}
