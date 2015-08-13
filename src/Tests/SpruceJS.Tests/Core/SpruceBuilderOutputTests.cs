using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Script;
using Xunit;

namespace SpruceJS.Tests.Core
{
	public class SpruceBuilderOutputTests
	{
		//[Fact]
		//public void OutputContainsScripts()
		//{
		//	const string fileval1 = "var enginetests1 = 123;";
		//	const string fileval2 = "var enginetests2 = 456;";

		//	var fileconfigMock = new Mock<IFileConfig>();
		//	fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\a.js", @"c:\b.js" });

		//	var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
		//		{ @"c:\a.js", new MockFileData(fileval1) },
		//		{ @"c:\b.js", new MockFileData(fileval2) }
		//	});

		//	var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };

		//	var output = engine.GetOutput();

		//	Assert.Contains(fileval1, output.JavaScriptBody);
		//	Assert.Contains(fileval2, output.JavaScriptBody);
		//	Assert.Contains(SpruceLib.Body, output.JavaScriptBody);
		//}

		[Fact]
		public void OutputContainsMinifiedScripts()
		{
			const string fileval1 = "var enginetests1 = 123;";
			const string fileval2 = "var enginetests2 = 456;";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData(fileval1) },
				{ @"c:\b.js", new MockFileData(fileval2) }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };

			var output = engine.GetOutput();

			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.Contains("enginetests1=123", output.JavaScriptBody);
			Assert.Contains("enginetests2=456", output.JavaScriptBody);
		}

		//[Fact]
		//public void OutputContainsModules()
		//{
		//	const string fileval1 = "define('e', function () { var enginetests1 = 123; });";
		//	const string fileval2 = "define('f', function () { var enginetests2 = 456; });";

		//	var fileconfigMock = new Mock<IFileConfig>();
		//	fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\a.js", @"c:\b.js", @"c:\c.js", @"c:\d.js" });
		//	fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\e.js", @"c:\f.js" });

		//	var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
		//		{ @"c:\e.js", new MockFileData(fileval1) },
		//		{ @"c:\f.js", new MockFileData(fileval2) }
		//	});

		//	var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };

		//	var output = engine.GetOutput();

		//	Assert.Contains(fileval1, output.JavaScriptBody);
		//	Assert.Contains(fileval2, output.JavaScriptBody);
		//	Assert.Contains(SpruceLib.Body, output.JavaScriptBody);
		//}

		[Fact]
		public void OutputNotContainsLibrary()
		{
			const string fileval1 = "define('e', function () { var enginetests1 = 123; });";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\a.js", @"c:\b.js", @"c:\c.js", @"c:\d.js" });
			fileconfigMock.Setup(i => i.Scripts).Returns(new[] { @"c:\e.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\e.js", new MockFileData(fileval1) }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem)
			{
				Minify = false,
				ExcludeScript = true
			};

			var output = engine.GetOutput();

			Assert.DoesNotContain(SpruceLib.Body, output.JavaScriptBody);
		}

		[Fact]
		public void MinifiedOutputNotContainsLibrary()
		{
			var fileconfigMock = new Mock<IFileConfig>();

			var fileSystem = new MockFileSystem();

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem)
			{
				Minify = true,
				ExcludeScript = true
			};

			var output = engine.GetOutput();

			Assert.DoesNotContain("var define", output.JavaScriptBody);
		}
	}
}
