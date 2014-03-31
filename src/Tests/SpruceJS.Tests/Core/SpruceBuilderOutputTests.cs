using System;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Script;
using Xunit;

namespace SpruceJS.Tests.Core
{
	public class SpruceBuilderOutputTests
	{
		[Fact]
		public void OutputContainsExternals()
		{
			const string fileval1 = "var enginetests1 = 123;";
			const string fileval2 = "var enginetests2 = 456;";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns(fileval1);
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns(fileval2);

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			var output = engine.GetOutput();

			Assert.Contains(fileval1, output.JavaScriptBody);
			Assert.Contains(fileval2, output.JavaScriptBody);
			Assert.Contains(SpruceLib.Body, output.JavaScriptBody);
		}

		[Fact]
		public void OutputContainsMinifiedExternals()
		{
			const string fileval1 = "var enginetests1 = 123;";
			const string fileval2 = "var enginetests2 = 456;";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns(fileval1);
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns(fileval2);

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			var output = engine.GetOutput();

			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.Contains("enginetests1=123", output.JavaScriptBody);
			Assert.Contains("enginetests2=456", output.JavaScriptBody);
		}

		[Fact]
		public void OutputContainsModules()
		{
			const string fileval1 = "define('e', function () { var enginetests1 = 123; });";
			const string fileval2 = "define('f', function () { var enginetests2 = 456; });";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b", "c", "d" });
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "e", "f" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("e")).Returns(fileval1);
			contentLoaderMock.Setup(i => i.GetContent("f")).Returns(fileval2);

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			var output = engine.GetOutput();

			Assert.Contains(fileval1, output.JavaScriptBody);
			Assert.Contains(fileval2, output.JavaScriptBody);
			Assert.Contains(SpruceLib.Body, output.JavaScriptBody);
		}

		[Fact]
		public void OutputNotContainsLibrary()
		{
			const string fileval1 = "define('e', function () { var enginetests1 = 123; });";

			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b", "c", "d" });
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "e" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("e")).Returns(fileval1);

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) {
				Minify = false, 
				ExcludeScript = true
			};

			var output = engine.GetOutput();

			Assert.Contains(fileval1, output.JavaScriptBody);
			Assert.DoesNotContain(SpruceLib.Body, output.JavaScriptBody);
		}

		[Fact]
		public void MinifiedOutputNotContainsLibrary()
		{
			var fileconfigMock = new Mock<IFileConfig>();

			var contentLoaderMock = new Mock<IContentLoader>();

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) {
				Minify = true,
				ExcludeScript = true
			};

			var output = engine.GetOutput();

			Assert.DoesNotContain("var define", output.JavaScriptBody);
		}
	}
}
