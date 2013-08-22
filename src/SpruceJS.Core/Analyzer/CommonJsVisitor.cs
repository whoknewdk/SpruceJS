using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Analyzer
{
	public class CommonJsVisitor : SpruceVisitor
	{
		private JSVariableField requireParam;

		public override void Visit(CallNode node)
		{
			Lookup lookup = node.Function as Lookup;
			if (lookup != null)
			{
				if (lookup.Name == "define" && node.Arguments.Count > 0)
					Indentifier = node.Arguments[0].ToString();

				if (lookup.VariableField.IsSameField(requireParam) && node.Arguments.SingleConstantArgument != null)
					Dependencies.Add(node.Arguments.SingleConstantArgument);
			}

			base.Visit(node);
		}

		public override void Visit(FunctionObject node)
		{
			IsValid = !string.IsNullOrEmpty(Indentifier);

			// Get "require" parem name
			if (requireParam == null && node.ParameterDeclarations.Count > 0)
				requireParam = (node.ParameterDeclarations[0] as ParameterDeclaration).IfNotNull(p => p.VariableField);

			base.Visit(node);
		}
	}
}
