using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime.Tree;
using Microsoft.Ajax.Utilities;
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

			iterate(tree.Children, 0);

			// If key is present module is valid
			IsValid = !String.IsNullOrEmpty(this.Name);
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
					var lst = child.Children.ToArray();

					// Set name
					if (lst[0] is ConstantWrapper)
						Name = lst[0].ToCode().Replace("\"", "");

					// Set dependencies
					if (lst[1] is ArrayLiteral)
					{
						var abc = lst[1].Children.ToArray();
						if (abc[0] is AstNodeList)
						{
							var depends = (AstNodeList) abc[0];
							foreach (var depend in depends)
								dependencies.Add(depend.ToCode().Replace("\"", ""));
						}

						return;
					}
				}

				// Search for "define"
				if (child is Lookup && child.ToCode() == "define")
					defineFound = true;

				iterate(child.Children, i+1);
			}
		}
	}
}
