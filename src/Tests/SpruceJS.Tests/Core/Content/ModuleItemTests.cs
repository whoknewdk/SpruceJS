using SpruceJS.Core.Content;
using Xunit;

namespace SpruceJS.Tests.Core.Content
{
	public class ModuleItemTests
	{
		[Fact]
		public void CanMapSingleDotRoot()
		{
			var a = new ModuleItem("c", "", "c", new[] { "./d" });
			Assert.Equal(1, a.Dependencies.Count);
			Assert.Equal("d", a.Dependencies[0]);
		}

		[Fact]
		public void CanMapSingleDot()
		{
			var a = new ModuleItem("a/b/c", "", "a/b/c", new[] { "./d" });
			Assert.Equal(1, a.Dependencies.Count);
			Assert.Equal("a/b/d", a.Dependencies[0]);
		}

		[Fact]
		public void CanMapDoubleDotRoot()
		{
			var a = new ModuleItem("a/b", "", "a/b", new[] { "../e" });
			Assert.Equal(1, a.Dependencies.Count);
			Assert.Equal("e", a.Dependencies[0]);
		}

		[Fact]
		public void CanMapDoubleDotDoubleRoot()
		{
			var a = new ModuleItem("a/b/c", "", "a/b/c", new[] { "../../e" });
			Assert.Equal(1, a.Dependencies.Count);
			Assert.Equal("e", a.Dependencies[0]);
		}

		[Fact]
		public void CanMapDoubleDot()
		{
			var a = new ModuleItem("a/b/c/e", "", "a/b/c/e", new[] { "../../d", "../e" });
			Assert.Equal(2, a.Dependencies.Count);
			Assert.Equal("a/d", a.Dependencies[0]);
			Assert.Equal("a/b/e", a.Dependencies[1]);
		}
	}
}
