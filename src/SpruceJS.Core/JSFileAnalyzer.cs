using System.Collections.Generic;
using Antlr.Runtime.Tree;
using SpruceJS.Core.Tree;

namespace SpruceJS.Core
{
	public class JSFileAnalyzer
	{
		JSCommonTree tree = new JSCommonTree();

		public string Name { get; private set; }

		private IList<string> dependencies = new List<string>();
		public IList<string> Dependencies { get { return dependencies; } }

		public bool IsValid { get; private set; }

		public JSFileAnalyzer(string content)
		{
			tree.Load(content);

			var children = tree.Children;
			for (int i = 0; i < children.Count; i++)
			{
				var t = children[i];
				
				// Find define
				if (t.Text == "define") {
					
					// Next must be string
					var next = children[i + 2];

					this.Name = next.Text;
				}

				// Find dependencies
				if (t.Text == "[")
				{
					var next = t;

					int j = 1;
					while (next.Text != "]")
					{
						if (next.Type == 6)
							dependencies.Add(next.Text);

						next = children[i + j++];
					}
				}
			}

			IsValid = true;
		}
	}
}
