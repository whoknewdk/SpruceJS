using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SpruceJS.Core.Parser;

namespace SpruceJS.Core
{
	public class JSFileAnalyzer
	{
		CommonTree tree;

		public JSFileAnalyzer(string content)
		{
			try
			{
				var stream = new ANTLRStringStream(content);
				var lexer = new JavaScriptLexer(stream);
				var tokenStream = new CommonTokenStream(lexer);
				var parser = new JavaScriptParser(tokenStream);
				JavaScriptParser.program_return programReturn = parser.program();

				tree = programReturn.Tree as CommonTree;
			}
			catch (Exception ex)
			{
				throw ex;
			}

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
