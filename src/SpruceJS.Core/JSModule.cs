using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public class JSModule : IEnumerable
	{
		public string Name { get; set; }
		public string Content { get; set; }
		public IList<string> Dependencies = new List<string>();

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
