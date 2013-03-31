using System.Collections.Generic;
using Antlr.Runtime.Tree;
using SpruceJS.Core.Tree;

namespace SpruceJS.Core
{
	public class JSFileAnalyzer
	{
		JSCommonTree tree = new JSCommonTree();

		public JSFileAnalyzer(string content)
		{
			tree.Load(content);

			var children = tree.Children;
			for (int i = 0; i < children.Count; i++)
			{
				CommonTree t = (CommonTree)children[i];
				
				// Find define
				if (t.Text == "define") {
					
					// Next must be string
					var next = children[i + 2];

					this.Name = next.Text.ToString();
				}
			}
		}

		public bool IsValid() {
			return true;
		}

		public string Name { get; private set; }

		public IList<string> GetDependencies()
		{
			return null;
		}
	}
}
