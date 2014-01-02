﻿using System.Linq;
using SpruceJS.Core.Config;
using Xunit;

namespace SpruceJS.Test.Core.Config
{
	public class SpruceConfigTests
	{
		[Fact]
		public void CanReadModules()
		{
			string json = @"{
								modules: [ 
									'abc.js',
									'def.js',
									'def.js'
								]
							}";

			var appconfig = new SpruceConfig();
			appconfig.LoadJson(json);

			Assert.Equal(3, appconfig.Modules.Count());
		}

		[Fact]
		public void CanReadExternals()
		{
			string json = @"{
								externals: [ 
									'abc.js',
									'def.js',
									'/**/*.js'
								]
							}";

			var appconfig = new SpruceConfig();
			appconfig.LoadJson(json);

			Assert.Equal(3, appconfig.Externals.Count());
		}

		[Fact]
		public void CanReadRecursiveDirectories()
		{
			string json = @"{
								modules: [ 
									'abc.js',
									'/**/*.js'
								]
							}";

			var appconfig = new SpruceConfig();
			appconfig.LoadJson(json);

			Assert.Equal(2, appconfig.Modules.Count());
			Assert.False(appconfig.Modules.ElementAt(0).Recursive);
			Assert.True(appconfig.Modules.ElementAt(1).Recursive);
		}

		[Fact]
		public void CanReadConfigIncludeTrue()
		{
			string json = @"{
								config: { include: true }
							}";

			var appconfig = new SpruceConfig();
			appconfig.LoadJson(json);

			Assert.True(appconfig.IncludeScript);
		}
	}
}