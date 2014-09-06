using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace SpruceJS.Core.Config
{
	public class SpruceConfig
	{
		public IEnumerable<ConfigElement> Externals { get; private set; }
		public IEnumerable<ConfigElement> Modules { get; private set; }
		public bool IncludeScript { get; private set; } 

		readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

		public void LoadJson(string json)
		{
			loadDirectoriesAndFile(json);
		}

		private void loadDirectoriesAndFile(string json)
		{
			var result = serializer.Deserialize<ConfigJson>(json);

			Modules = (result.modules ?? new string[0]).Select(x => new ConfigElement { Path = x, Recursive = x.Contains("**/*") });
			Externals = (result.externals ?? new string[0]).Select(x => new ConfigElement { Path = x });

			IncludeScript = result.config.includescript;
		}
	}

	public struct ConfigElement
	{
		public string Path;
		public bool Recursive;
	}

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
