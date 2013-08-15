using System.Collections.Generic;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Content;
using SpruceJS.Core.Minification;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class SpruceApplicationTest
	{
		[Fact]
		public void CanAddModules()
		{
			var fileconfigMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddModule(new ModuleItem { Name = "a" });
			jsapp.AddModule(new ModuleItem { Name = "b" });
			jsapp.AddModule(new ModuleItem { Name = "c" });
			jsapp.AddModule(new ModuleItem { Name = "d" });
		}

		[Fact]
		public void CanAddExternals()
		{
			var fileconfigMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddExternal(new ExternalItem());
			jsapp.AddExternal(new ExternalItem());
			jsapp.AddExternal(new ExternalItem());
			jsapp.AddExternal(new ExternalItem());
		}

		[Fact]
		public void CanGetMinifiedOutput()
		{
			var fileconfigMock = new Mock<IMinifier>();
			fileconfigMock
				.Setup(i => i.Minify(It.IsAny<ModuleItemList>(), It.IsAny<IEnumerable<ExternalItem>>()))
				.Returns(new MinifyResult { JavaScriptBody = "JSBody"});

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			Assert.Equal("JSBody", jsapp.GetMinifiedOutput().JavaScriptBody);
		}

		[Fact]
		public void CanGetOutput()
		{
			var fileconfigMock = new Mock<IMinifier>();
			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddExternal(new ExternalItem { Content = "JSBody" });

			Assert.Contains("JSBody", jsapp.GetOutput());
		}
	}
}
