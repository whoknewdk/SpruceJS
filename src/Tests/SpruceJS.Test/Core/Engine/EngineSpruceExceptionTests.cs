using System;
using Moq;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Engine;
using SpruceJS.Core.Exceptions.Modules;
using Xunit;
using E = SpruceJS.Core.Engine;

namespace SpruceJS.Test.Core.Engine
{
	public class EngineSpruceExceptionTests
	{
		[Fact]
		public void OutputThrowsModuleKeyDoesNotExistException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('b', function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false, Mode = ModuleMode.Amd };

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyDoesNotExistException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('b', function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true, Mode = ModuleMode.Amd};

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('a', function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputThrowsModuleKeyNotUniqueException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', ['c'], function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('a', function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true, Mode = ModuleMode.Amd };

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void OutputThrowsModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', ['b'], function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('b', ['a'], function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false, Mode = ModuleMode.Amd };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void MinifiedOutputModuleKeyCircularReferenceException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define('a', ['b'], function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define('b', ['a'], function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true, Mode = ModuleMode.Amd };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.GetOutput(); }
			);
		}

		[Fact]
		public void NamelessModulesNotThrowsException()
		{
			var fileconfigMock = new Mock<IFileConfig>();
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent(It.IsAny<String>())).Returns("");
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define(function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define([], function () { var enginetests2 = 456; });");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

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
			fileconfigMock.Setup(i => i.Files).Returns(new[] { "a", "b" });

			var contentLoaderMock = new Mock<IContentLoader>();
			contentLoaderMock.Setup(i => i.GetContent("a")).Returns("define(function () { var enginetests1 = 123; });");
			contentLoaderMock.Setup(i => i.GetContent("b")).Returns("define();");

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			Assert.Throws<ModuleNotValidException>(
				() => { engine.GetOutput(); }
			);
		}
	}
}
