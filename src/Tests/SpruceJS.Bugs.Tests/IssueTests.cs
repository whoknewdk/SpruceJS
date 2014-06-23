using System;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.IO;
using Xunit;

namespace SpruceJS.Bugs.Tests
{
	public class IssueTests
	{
		[Fact] // Issue #4
		public void ModuleNameShouldStripSpruceJsExtension()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "/main.spruce.js" });

			var contentLoaderMock = new Mock<IFileSystem>();
			contentLoaderMock.Setup(i => i.ReadAllText(It.IsAny<String>())).Returns("define(function () {});");

			var engine = new SpruceBuilder(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			var output = engine.GetOutput();

			Assert.Contains("define('main'", output.JavaScriptBody);
		}
	}
}
