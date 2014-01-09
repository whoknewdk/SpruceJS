using System.Collections.Generic;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Content;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Minification;
using SpruceJS.Core.Script;
using Xunit;

namespace SpruceJS.Tests.Core
{
	public class SpruceApplicationTest
	{
		[Fact]
		public void CanAddModules()
		{
			var minifierMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(minifierMock.Object);

			jsapp.AddModule(new ModuleItem("a", "", "a"));
			jsapp.AddModule(new ModuleItem("b", "", "b"));
			jsapp.AddModule(new ModuleItem("c", "", "c"));
			jsapp.AddModule(new ModuleItem("d", "", "d"));
		}

		[Fact]
		public void CanAddExternals()
		{
			var minifierMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(minifierMock.Object);

			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
		}

		[Fact]
		public void CanGetMinifiedOutput()
		{
			var minifierMock = new Mock<IMinifier>();
			minifierMock
				.Setup(i => i.Minify())
				.Returns(new EngineOutput { JavaScriptBody = "JSBody"});

			var jsapp = new SpruceApplication(minifierMock.Object);

			Assert.Equal("JSBody", jsapp.GetMinifiedOutput().JavaScriptBody);
		}

		[Fact]
		public void CanGetOutput()
		{
			var minifierMock = new Mock<IMinifier>();
			var jsapp = new SpruceApplication(minifierMock.Object);

			jsapp.AddExternal(new ExternalItem("", "JSBody"));

			Assert.Contains("JSBody", jsapp.GetOutput());
			Assert.Contains(SpruceLib.Body, jsapp.GetOutput());
		}
	}
}
