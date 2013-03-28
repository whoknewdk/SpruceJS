using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSApp
	{
		public IList<JSModule> Modules = new List<JSModule>();

		public void Add(JSModule module)
		{
			Modules.Add(module);
		}
	}
}
