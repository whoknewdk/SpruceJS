using System.Linq;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Visitor
{
	public class ModuleVisitor : SpruceVisitor
	{
		private JSVariableField requireParam;

		private bool isAMD;
		private CodeSettings settings = new CodeSettings();

		public override void Visit(CallNode node)
		{
			Lookup lookup = node.Function as Lookup;
			if (lookup != null)
			{
				// define();
				if (lookup.Name == "define" && node.Arguments.Count > 1)
				{
					foreach (var argument in node.Arguments)
					{
						// "id"
						if (argument is ConstantWrapper)
							Indentifier = node.Arguments[0].ToString();

						// [..]
						if (argument is ArrayLiteral)
						{
							isAMD = true;

							var imports = argument.Children.ToArray();
							if (imports[0] is AstNodeList)
							{
								foreach (var depend in (AstNodeList)imports[0])
									Dependencies.Add(OutputVisitor.Apply(depend, settings).Replace("\"", ""));
							}
						}
					}
				}

				// require(..);
				if (!isAMD && lookup.VariableField.IsSameField(requireParam) && node.Arguments.SingleConstantArgument != null)
					Dependencies.Add(node.Arguments.SingleConstantArgument);
			}

			base.Visit(node);
		}

		public override void Visit(FunctionObject node)
		{
			IsValid = true;

			// Get "require" parem name
			if (requireParam == null && node.ParameterDeclarations.Count > 0)
				requireParam = (node.ParameterDeclarations[0] as ParameterDeclaration).IfNotNull(p => (p.Binding as BindingIdentifier).VariableField);

			base.Visit(node);
		}
	}
}
