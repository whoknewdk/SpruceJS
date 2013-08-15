using System.Linq;
using SpruceJS.Core.Config;
using Xunit;

namespace SpruceJS.Test.Core.Config
{
	public class SpruceConfigTests
	{
		[Fact]
		public void CanReadModules()
		{
			string xml = @"<sprucejs>
							<modules>
								<add path='abc.js' />
								<add path='def.js' />
								<add path='def.js' />
							</modules>
						</sprucejs>";

			var appconfig = new SpruceConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(3, appconfig.Modules.Count());
		}

		[Fact]
		public void CanReadExternals()
		{
			string xml = @"<sprucejs>
							<externals>
								<add path='/abc' />
								<add path='/def/' />
								<add path='/def' />
							</externals>
						</sprucejs>";

			var appconfig = new SpruceConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(3, appconfig.Externals.Count());
		}

		[Fact]
		public void CanReadRecursiveDirectories()
		{
			string xml = @"<sprucejs>
							<modules>
								<add path='abc' />
								<add path='def' recursive='true' />
							</modules>
						</sprucejs>";

			var appconfig = new SpruceConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(2, appconfig.Modules.Count());
			Assert.False(appconfig.Modules.ElementAt(0).Recursive);
			Assert.True(appconfig.Modules.ElementAt(1).Recursive);
		}
	}
}