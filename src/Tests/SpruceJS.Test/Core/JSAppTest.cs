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

			jsapp.Add(new JSModule {});
			jsapp.Add(new JSModule { });
			jsapp.Add(new JSModule { });
			jsapp.Add(new JSModule { });

			Assert.Equal(4, jsapp.Modules.Count);
		}
	}
}
