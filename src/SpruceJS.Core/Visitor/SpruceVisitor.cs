using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Visitor
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
			CodeSettings settings = new CodeSettings();
			settings.AddKnownGlobal("define");

			JSParser parser = new JSParser();
			parser.Settings = settings;

			Visit(parser.Parse(script));
		}
	}
}
