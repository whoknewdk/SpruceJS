using System.Collections.Generic;

namespace SpruceJS.Core
{
	public class JSModule
	{
		public string Name { get; set; }
		public string Url { get; set; }
		public string Content { get; set; }
		public IList<string> Dependencies = new List<string>();
	}
}
