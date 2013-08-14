using System;
using Moq;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;
using Xunit;

namespace SpruceJS.Test.Core.Engine
{
	public class EngineTests
	{
		[Fact]
		public void RenderTest()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b" });
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "d", "e", "f", "g" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("var enginetests = 123;");

			var engine = new SpruceJS.Core.Engine.Engine(fileconfigMock.Object, contentLoaderMock.Object)
				{
					Minify = false
				};
			
			var output = engine.Render();

			Assert.Contains("var enginetests = 123;var enginetests = 123;", output.JavaScriptBody);
		}

		[Fact]
		public void RenderMinifyTest()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Externals).Returns(new[] { "a", "b" });
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "d", "e", "f", "g" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("var enginetests = 123;");

			var engine = new SpruceJS.Core.Engine.Engine(fileconfigMock.Object, contentLoaderMock.Object)
				{
					Minify = true
				};

			var output = engine.Render();

			Assert.DoesNotContain("var enginetests = 123;var enginetests = 123;", output.JavaScriptBody);
			Assert.Contains("var enginetests=123,enginetests=123;", output.JavaScriptBody);
		}
	}
}
