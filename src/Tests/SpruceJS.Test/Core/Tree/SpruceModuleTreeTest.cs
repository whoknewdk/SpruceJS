using System;
using SpruceJS.Core.Tree;
using Xunit;

namespace SpruceJS.Test.Core.Tree
{
	public class SpruceModuleTreeTest
	{
		[Fact]
		public void NoChildrenPresentWhenContentNotLoaded()
		{
			var tree = new SpruceModuleTree();
			Assert.Throws<NullReferenceException>(
				() => { var c = tree.Children; }
			);
		}

		[Fact]
		public void ChildrenPresentWhenContentLoaded()
		{
			var tree = new SpruceModuleTree();

			tree.Load("");

			Assert.DoesNotThrow(
				() => { var c = tree.Children; }
			);
		}
	}
}
