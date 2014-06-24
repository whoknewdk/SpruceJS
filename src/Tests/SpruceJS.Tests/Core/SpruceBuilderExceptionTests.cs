﻿using System.IO;
using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.IO;
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
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('b', function () { var enginetests2 = 456; });");
			fileSystemMock.Setup(i => i.ReadAllText("c.js")).Throws<FileNotFoundException>();

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyDoesNotExistException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('b', function () { var enginetests2 = 456; });");
			fileSystemMock.Setup(i => i.ReadAllText("c.js")).Throws<FileNotFoundException>();

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('a', function () { var enginetests2 = 456; });");

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('a', function () { var enginetests2 = 456; });");
			fileSystemMock.Setup(i => i.ReadAllText("c.js")).Throws<FileNotFoundException>();

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', ['b'], function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('b', ['a'], function () { var enginetests2 = 456; });");

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define('a', ['b'], function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define('b', ['a'], function () { var enginetests2 = 456; });");

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void NamelessModulesNotThrowsException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define(function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define([], function () { var enginetests2 = 456; });");

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = true };

			Assert.DoesNotThrow(
				() =>
					{
						engine.GetOutput();
					}
			);
		}

		[Fact]
		public void OutputThrowsNotValidModuleException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a.js", "b.js" });

			var fileSystemMock = new Mock<IFileSystem>();
			fileSystemMock.Setup(i => i.ReadAllText("a.js")).Returns("define(function () { var enginetests1 = 123; });");
			fileSystemMock.Setup(i => i.ReadAllText("b.js")).Returns("define();");

			var engine = new SpruceBuilder(fileconfigMock.Object, fileSystemMock.Object) { Minify = true };

			Assert.Throws<ModuleNotValidException>(
				() => { engine.GetOutput(); }
			);
		}
	}
}