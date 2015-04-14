using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Modules.Exceptions;
using Xunit;

namespace SpruceJS.Tests.Core
{
	public class SpruceBuilderExceptionTests
	{
		[Fact]
		public void OutputThrowsModuleKeyDoesNotExistException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', ['c'], function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('b', function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyDoesNotExistException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', ['c'], function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('b', function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('a', function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', ['c'], function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('a', function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', ['b'], function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('b', ['a'], function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = false };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define('a', ['b'], function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define('b', ['a'], function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };
			engine.LoadModule(@"c:\a.js");

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void NamelessModulesNotThrowsException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define(function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define([], function () { var enginetests2 = 456; });") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };

			Assert.DoesNotThrow(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsNotValidModuleException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Modules).Returns(new[] { @"c:\a.js", @"c:\b.js" });

			var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData> {
				{ @"c:\a.js", new MockFileData("define(function () { var enginetests1 = 123; });") },
				{ @"c:\b.js", new MockFileData("define();") }
			});

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystem) { Minify = true };

			Assert.Throws<ModuleNotValidException>(
				() => { engine.GetOutput(); }
			);
		}
	}
}
