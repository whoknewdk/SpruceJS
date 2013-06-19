using System.Collections;
using System.Collections.Generic;

namespace SpruceJS.Core
{
	public class JSModule : IEnumerable
	{
		public string Name { get; set; }
		public string Url { get; set; }
		public string Content { get; set; }
		public IList<string> Dependencies = new List<string>();

		public IEnumerator GetEnumerator()
		{
			foreach (string name in Dependencies)
				yield return name;
		}
	}
}
