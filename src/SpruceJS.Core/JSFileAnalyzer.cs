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
		}

		public bool IsValid() {
			return true;
		}

		public string GetName() {
			return "";
		}

		public IList<string> GetDependencies()
		{
			return null;
		}
	}
}
