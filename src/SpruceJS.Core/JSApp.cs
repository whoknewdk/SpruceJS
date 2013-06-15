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
			return minificator.Minify(Modules);
		}

		public int Count
		{
			get { return Modules.Count; }
		}
	}
}
