﻿using System.Collections.Generic;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Content;
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
			var fileconfigMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddModule(new ModuleItem("a", "", "a"));
			jsapp.AddModule(new ModuleItem("b", "", "b"));
			jsapp.AddModule(new ModuleItem("c", "", "c"));
			jsapp.AddModule(new ModuleItem("d", "", "d"));
		}

		[Fact]
		public void CanAddExternals()
		{
			var fileconfigMock = new Mock<IMinifier>();

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
		}

		[Fact]
		public void CanGetMinifiedOutput()
		{
			var fileconfigMock = new Mock<IMinifier>();
			fileconfigMock
				.Setup(i => i.Minify(It.IsAny<ModuleItemList>(), It.IsAny<IEnumerable<ExternalItem>>(), true))
				.Returns(new MinifyOutput { JavaScriptBody = "JSBody"});

			var jsapp = new SpruceApplication(fileconfigMock.Object);

			Assert.Equal("JSBody", jsapp.GetMinifiedOutput().JavaScriptBody);
		}

		[Fact]
		public void CanGetOutput()
		{
			var fileconfigMock = new Mock<IMinifier>();
			var jsapp = new SpruceApplication(fileconfigMock.Object);

			jsapp.AddExternal(new ExternalItem("", "JSBody"));

			Assert.Contains("JSBody", jsapp.GetOutput());
			Assert.Contains(SpruceLib.Body, jsapp.GetOutput());
		}
	}
}