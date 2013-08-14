using System;
using System.IO;
using System.Linq;
using System.Web;
using Moq;
using SpruceJS.Web;
using Xunit;

namespace SpruceJS.Test.Build
{
	public class WebSpruceConfigTests
	{
		[Fact]
		public void LoadTest()
		{
			// MapPath
			var serverMock = new Mock<HttpServerUtilityBase>();
			serverMock.Setup(i => i.MapPath(It.IsAny<String>()))
			   .Returns((String a) => "D:\\" + a);

			// HttpContext & Server
			var contextMock = new Mock<HttpContextBase>(MockBehavior.Loose);
			contextMock.Setup(i => i.Server).Returns(serverMock.Object);
			
			// We only want to test that it gets to the point of trying to load this file (and fails)
			var config = new WebSpruceConfig(contextMock.Object);
			Assert.Throws<FileNotFoundException>(() => config.Load("doesnotexits.spruce.config"));
		}

		[Fact]
		public void LoadXmlTest()
		{
			// HttpContext
			var contextMock = new Mock<HttpContextBase>(MockBehavior.Loose);

			// Config
			var config = new WebSpruceConfig(contextMock.Object);
			config.LoadXml(@"<sprucejs>

								<externals>
									<add path='/libs/mylib.js' />
								</externals>

								<modules>
									<add path='/shared/models/main.js' />
									<add path='/shared/models/*.js' />
									<add path='/shared/models/' />
									<add path='views/' />
								</modules>

							</sprucejs>");

			Assert.Equal(1, config.Externals.Count());
			Assert.Equal(4, config.Modules.Count());

			Assert.Equal("/libs/mylib.js", config.Externals.ElementAt(0).Path);
			Assert.Equal("/shared/models/main.js", config.Modules.ElementAt(0).Path);
			Assert.Equal("/shared/models/*.js", config.Modules.ElementAt(1).Path);
			Assert.Equal("/shared/models/", config.Modules.ElementAt(2).Path);
			Assert.Equal("views/", config.Modules.ElementAt(3).Path);
		}
	}
}
