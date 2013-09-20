using System;
using Moq;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Script;
using Xunit;
using E = SpruceJS.Core.Engine;

namespace SpruceJS.Test.Core.Engine
{
	public class EngineOutputTests
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			var output = engine.GetOutput();

			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.DoesNotContain(fileval1, output.JavaScriptBody);
			Assert.Contains("var enginetests1=123,enginetests2=456;", output.JavaScriptBody);
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			var output = engine.GetOutput();

			Assert.Contains(fileval2, output.JavaScriptBody);
			Assert.Contains(fileval2, output.JavaScriptBody);
			Assert.Contains(SpruceLib.Body, output.JavaScriptBody);
		}
	}
}
