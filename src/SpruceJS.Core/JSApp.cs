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

		IMinificator minificator;
		public JSApp(IMinificator minificator)
		{
			this.minificator = minificator;
		}

		public void Add(JSModule module)
		{
			Modules.Add(module);
		}

		public MinifyResult GetBuild(string appName)
		{
			return minificator.Minify(Modules, appName);
		}

		public int Count
		{
			get { return Modules.Count; }
		}
	}
}
