using SpruceJS.Publish;
using Xunit;

namespace SpruceJS.Tests.Build
{
	public class PathUtilTests
	{
		[Fact]
		public void CanGetPathDifference()
		{
			Assert.Equal("file.txt", PathUtil.GetPathDifference(@"D:\first\", @"D:\first\file.txt"));
			Assert.Equal("file.txt", PathUtil.GetPathDifference(@"D:\first\second\", @"D:\first\second\file.txt"));
			Assert.Equal("file.txt", PathUtil.GetPathDifference(@"D:\first\second\third\", @"D:\first\second\third\file.txt"));

			Assert.Equal("third\\file.txt", PathUtil.GetPathDifference(@"D:\first\second\", @"D:\first\second\third\file.txt"));
			Assert.Equal("third\\fourth\\file.txt", PathUtil.GetPathDifference(@"D:\first\second\", @"D:\first\second\third\fourth\file.txt"));

			Assert.Equal("file.txt", PathUtil.GetPathDifference(@"D:\first\second", @"D:\first\second\file.txt"));
			Assert.Equal("third\\fourth\\file.txt", PathUtil.GetPathDifference(@"D:\first\second", @"D:\first\second\third\fourth\file.txt"));
		}
	}
}
