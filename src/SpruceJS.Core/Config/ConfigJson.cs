
namespace SpruceJS.Core.Config
{
	internal class ConfigJson
	{
		public string[] modules;
		public string[] externals;
		public Config config = new Config();
	}

	internal class Config
	{
		public bool includescript = true;
	}
}