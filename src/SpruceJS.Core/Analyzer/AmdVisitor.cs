using System.Linq;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Analyzer
{
	public class AmdVisitor : SpruceVisitor
	{
		public override void Visit(CallNode node)
		{
			Lookup lookup = node.Function as Lookup;
			if (lookup != null)
			{
				if (lookup.Name == "define" && node.Arguments.Count > 1)
				{
					foreach (var argument in node.Arguments)
					{
						if (argument is ConstantWrapper)
							Indentifier = node.Arguments[0].ToString();

						if (argument is ArrayLiteral)
						{
							var imports = argument.Children.ToArray();
							if (imports[0] is AstNodeList)
							{
								foreach (var depend in (AstNodeList)imports[0])
									Dependencies.Add(depend.ToCode().Replace("\"", ""));
							}
						}
					}
				}
			}

			base.Visit(node);
		}

		public override void Visit(FunctionObject node)
		{
			IsValid = true;

			base.Visit(node);
		}
	}
}
