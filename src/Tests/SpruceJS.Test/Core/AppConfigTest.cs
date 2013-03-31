using SpruceJS.Core;
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
	}
}