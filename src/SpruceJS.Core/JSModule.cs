using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSModule
	{
		public string Name { get; set; }
		public string Content { get; set; }
		public IList<string> Dependencies = new List<string>();

		public bool Marked = false;
		public bool TempMarked = false;
	}
}
