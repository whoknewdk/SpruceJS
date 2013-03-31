using System;
using SpruceJS.Core.Tree;
using Xunit;

namespace SpruceJS.Test.Core.Tree
{
	public class JSCommenTreeTest
	{
		[Fact]
		public void NoChildrenPresentWhenContentNotLoaded()
		{
			var tree = new JSCommonTree();
			Assert.Throws<NullReferenceException>(
				() => { var c = tree.Children; }
			);
		}

		[Fact]
		public void ChildrenPresentWhenContentLoaded()
		{
			var tree = new JSCommonTree();

			tree.Load("");

			Assert.DoesNotThrow(
				() => { var c = tree.Children; }
			);
		}
	}
}
