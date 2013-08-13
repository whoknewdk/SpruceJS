using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Tree
{
	public class JSCommonTree
	{
		private Block block;

		public IEnumerable<AstNode> Children
		{
			get { return block.Children; }
		}

		public void Load(string content)
		{
			JSParser parser = new JSParser(content);

			parser.CompilerError += ErrorHandler;

			CodeSettings settings = new CodeSettings();
			settings.AddKnownGlobal("define");

			block = parser.Parse(settings);
		}

		static void ErrorHandler(object source, JScriptExceptionEventArgs ea)
		{
			//throw new Exception(ea.Error.ToString());
		}
	}
}
