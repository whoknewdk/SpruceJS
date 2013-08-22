using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Tree
{
	public class SpruceModuleTree
	{
		public Block Block;

		public IEnumerable<AstNode> Children
		{
			get { return Block.Children; }
		}

		public void Load(string content)
		{
			JSParser parser = new JSParser(content);

			parser.CompilerError += ErrorHandler;

			CodeSettings settings = new CodeSettings();
			settings.AddKnownGlobal("define");

			Block = parser.Parse(settings);
		}

		static void ErrorHandler(object source, JScriptExceptionEventArgs ea)
		{
			//throw new Exception(ea.Error.ToString());
		}
	}
}
