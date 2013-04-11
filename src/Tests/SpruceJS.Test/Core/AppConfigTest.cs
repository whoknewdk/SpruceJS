using SpruceJS.Core;
using SpruceJS.Core.Config;
using Xunit;

namespace SpruceJS.Test
{
	public class AppConfigTest
	{
		[Fact]
		public void FilesCanBeRead()
		{
			string xml = @"<files>
							<file path='abc' />
							<file path='def' />
							<file path='def' />
						</files>";

			var appconfig = new AppConfig(xml);

			Assert.Equal(3, appconfig.Files.Count);
		}

		[Fact]
		public void DirectoriesCanBeRead()
		{
			string xml = @"<files>
							<directory path='abc' />
							<directory path='def' />
							<directory path='def' />
						</files>";

			var appconfig = new AppConfig(xml);

			Assert.Equal(3, appconfig.Directories.Count);
		}

		[Fact]
		public void RecursiveDirectoriesCanBeRead()
		{
			string xml = @"<files>
							<directory path='abc' />
							<directory path='def' recursive='true' />
						</files>";

			var appconfig = new AppConfig(xml);

			Assert.Equal(2, appconfig.Directories.Count);
			Assert.False(appconfig.Directories[0].Recursive);
			Assert.True(appconfig.Directories[1].Recursive);
		}
	}
}