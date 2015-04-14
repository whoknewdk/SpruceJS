using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using Xunit;

namespace SpruceJS.Bugs.Tests
{
	public class IssueTests
	{
		[Fact] // Issue #4
		public void ModuleNameShouldStripSpruceJsExtension()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\main.spruce.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\main.spruce.js", new MockFileData("define(function () {});") },
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };
			engine.LoadModule(@"c:\main.spruce.js");

			var output = engine.GetOutput();

			Assert.Contains("define('main'", output.JavaScriptBody);
		}
	}
}
