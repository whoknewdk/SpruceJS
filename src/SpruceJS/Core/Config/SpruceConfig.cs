using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace SpruceJS.Core.Config
{
	public class SpruceConfig
	{
		public IEnumerable<ConfigElement> Scripts { get; private set; }
		public IEnumerable<ConfigElement> Modules { get; private set; }
		public bool IncludeScript { get; private set; } 
		public string BasePath { get; private set; }
		public string[] Extensions { get; private set; }

		readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

		public void LoadJson(string json)
		{
			loadDirectoriesAndFile(json);
		}

		private void loadDirectoriesAndFile(string json)
		{
			var result = serializer.Deserialize<ConfigJson>(json);

			Modules = (result.modules ?? new string[0]).Select(x => new ConfigElement { Path = x.Replace("**/", ""), Recursive = x.Contains("**/*") });
			Scripts = (result.scripts ?? new string[0]).Select(x => new ConfigElement { Path = x.Replace("**/", ""), Recursive = x.Contains("**/*") });

			IncludeScript = result.config.includescript;
			BasePath = result.config.basepath;
			Extensions = result.config.extensions;
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
		public string[] scripts;
		public Config config = new Config();
	}

	internal class Config
	{
		public bool includescript = true;
		public string basepath = "";
		public string[] extensions = new string[0];
	}
}
