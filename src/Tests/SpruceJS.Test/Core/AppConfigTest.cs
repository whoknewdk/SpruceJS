using SpruceJS.Core;
using Xunit;

namespace SpruceJS.Test
{
	public class AppConfigTest
	{
		[Fact]
		public void FilesCountTest()
		{
			string xml = @"<files>
							<file path='abc' />
							<file path='def' />
							<file path='def' />
						</files>";

			var appconfig = new AppConfig(xml);

			Assert.Equal(3, appconfig.Files.Count);
		}
	}
}