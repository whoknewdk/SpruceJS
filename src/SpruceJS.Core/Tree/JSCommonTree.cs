using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SpruceJS.Core.Parser;

namespace SpruceJS.Core.Tree
{
	public class JSCommonTree
	{
		CommonTree tree = null;

		public IList<ITree> Children
		{
			get { return tree.Children; }
		}

		public void Load(string content)
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
		}
	}
}
