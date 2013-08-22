using System.Collections.Generic;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Tree;

namespace SpruceJS.Core.Analyzer
{
	public abstract class SpruceVisitor : TreeVisitor
	{
		public IList<string> Dependencies { get; protected set; }
		public string Indentifier { get; protected set; }
		public bool IsValid { get; protected set; }

		protected SpruceVisitor()
		{
			Dependencies = new List<string>();
		}

		public void Load(string script)
		{
			var tree = new SpruceModuleTree();
			tree.Load(script);
			Visit(tree.Block);
		}
	}
}
