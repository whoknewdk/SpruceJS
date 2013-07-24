using SpruceJS.Core;
using SpruceJS.Core.Config;
using Xunit;

namespace SpruceJS.Test
{
	public class AppConfigTest
	{
		[Fact]
		public void ModulesCanBeRead()
		{
			string xml = @"<sprucejs>
							<modules>
								<add path='abc.js' />
								<add path='def.js' />
								<add path='def.js' />
							</modules>
						</sprucejs>";

			var appconfig = new AppConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(3, appconfig.Modules.Count);
		}

		[Fact]
		public void ExternalsCanBeRead()
		{
			string xml = @"<sprucejs>
							<externals>
								<add path='/abc' />
								<add path='/def/' />
								<add path='/def' />
							</externals>
						</sprucejs>";

			var appconfig = new AppConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(3, appconfig.Externals.Count);
		}

		[Fact]
		public void RecursiveDirectoriesCanBeRead()
		{
			string xml = @"<sprucejs>
							<modules>
								<add path='abc' />
								<add path='def' recursive='true' />
							</modules>
						</sprucejs>";

			var appconfig = new AppConfig();
			appconfig.LoadXml(xml);

			Assert.Equal(2, appconfig.Modules.Count);
			Assert.False(appconfig.Modules[0].Recursive);
			Assert.True(appconfig.Modules[1].Recursive);
		}
	}
}