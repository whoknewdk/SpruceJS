using System.Collections.Generic;
using System.Linq;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Tree;

namespace SpruceJS.Core.Analyzer
{
	public class AMDStructureAnalyzer
	{
		readonly SpruceModuleTree tree = new SpruceModuleTree();

		public string Name { get; private set; }

		private IList<string> dependencies = new List<string>();
		public IList<string> Dependencies { get { return dependencies; } }

		public bool IsValid { get; private set; }

		public AMDStructureAnalyzer(string content)
		{
			tree.Load(content);

			iterate(tree.Children, 0);
		}

		private void iterate(IEnumerable<AstNode> nodes, int i)
		{
			// Everything has already been found!
			if (dependencies.Count > 0)
				return;

			bool defineFound = false;
			foreach (var child in nodes)
			{
				// Search for key/name
				if (defineFound && child is AstNodeList)
				{
					defineFound = false;

					foreach (var astNode in child.Children)
					{
						// Read name
						if (astNode is ConstantWrapper)
							Name = astNode.ToCode().Replace("\"", "");

						// Read dependencies
						if (astNode is ArrayLiteral)
						{
							var imports = astNode.Children.ToArray();
							if (imports[0] is AstNodeList)
							{
								foreach (var depend in (AstNodeList)imports[0])
									dependencies.Add(depend.ToCode().Replace("\"", ""));
							}
						}

						if (astNode is FunctionObject)
							IsValid = true;
					}					
					
					return;
				}

				// Search for "define"
				if (child is Lookup && child.ToCode() == "define")
					defineFound = true;

				iterate(child.Children, i+1);
			}
		}
	}
}
