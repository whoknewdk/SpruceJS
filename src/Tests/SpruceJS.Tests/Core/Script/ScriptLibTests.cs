using SpruceJS.Core.Script;
using Xunit;

namespace SpruceJS.Tests.Core.Script
{
	public class ScriptLibTests
	{
		[Fact]
		public void JsLibraryExists()
		{
			Assert.NotNull(SpruceLib.Body);
			Assert.Contains("define", SpruceLib.Body);
		}
	}
}
