using Moq;
using SpruceJS.Core;
using SpruceJS.Core.Combiner;
using SpruceJS.Core.Modules;
using SpruceJS.Core.Script;
using Xunit;

namespace SpruceJS.Tests.Core
{
	public class SpruceApplicationTest
	{
		[Fact]
		public void CanAddModules()
		{
			var combinerMock = new Mock<ICombiner>();

			var jsapp = new SpruceApplication(combinerMock.Object);

			jsapp.AddModule(new ModuleItem("a", "", "a"));
			jsapp.AddModule(new ModuleItem("b", "", "b"));
			jsapp.AddModule(new ModuleItem("c", "", "c"));
			jsapp.AddModule(new ModuleItem("d", "", "d"));
		}

		[Fact]
		public void CanAddExternals()
		{
			var combinerMock = new Mock<ICombiner>();

			var jsapp = new SpruceApplication(combinerMock.Object);

			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
			jsapp.AddExternal(new ExternalItem("", ""));
		}

		[Fact]
		public void CanGetMinifiedOutput()
		{
			var combinerMock = new Mock<ICombiner>();
			combinerMock
				.Setup(i => i.GetOutput())
				.Returns(new CombinerOutput { JavaScriptBody = "JSBody" });

			var jsapp = new SpruceApplication(combinerMock.Object);

			Assert.Equal("JSBody", jsapp.GetMinifiedOutput().JavaScriptBody);
		}

		[Fact]
		public void CanGetOutput()
		{
			var jsapp = new SpruceApplication(new StandardCombiner());

			jsapp.AddExternal(new ExternalItem("", "JSBody"));

			Assert.Contains("JSBody", jsapp.GetMinifiedOutput().JavaScriptBody);
			Assert.Contains(SpruceLib.Body, jsapp.GetMinifiedOutput().JavaScriptBody);
		}
	}
}
