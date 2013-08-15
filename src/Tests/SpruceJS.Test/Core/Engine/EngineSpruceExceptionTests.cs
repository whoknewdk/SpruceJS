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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.Render(); }
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyDoesNotExistException>(
				() => { engine.Render(); }
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
				() => { engine.Render(); }
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyNotUniqueException>(
				() => { engine.Render(); }
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = false };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.Render(); }
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

			var engine = new E.Engine(fileconfigMock.Object, contentLoaderMock.Object) { Minify = true };

			Assert.Throws<ModuleKeyCircularReferenceException>(
				() => { engine.Render(); }
			);
		}
	}
}
