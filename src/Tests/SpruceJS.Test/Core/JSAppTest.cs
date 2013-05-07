using SpruceJS.Core;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class JSAppTest
	{
		[Fact]
		public void ModulesCountTest()
		{
			var jsapp = new JSApp();

			jsapp.Add(new JSModule { Name = "a" });
			jsapp.Add(new JSModule { Name = "b" });
			jsapp.Add(new JSModule { Name = "c" });
			jsapp.Add(new JSModule { Name = "d" });

			Assert.Equal(4, jsapp.Count);
		}
	}
}
