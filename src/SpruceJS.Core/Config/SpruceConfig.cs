using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace SpruceJS.Core.Config
{
	public class SpruceConfig : ISpruceConfig
	{
		public IEnumerable<ConfigElement> Externals { get; private set; }
		public IEnumerable<ConfigElement> Modules { get; private set; }

		JavaScriptSerializer serializer = new JavaScriptSerializer();

		public void LoadJson(string json)
		{
			loadDirectoriesAndFile(json);
		}

		public void Load(string json)
		{
			loadDirectoriesAndFile(GetFullPathContent(json));
		}

		private void loadDirectoriesAndFile(string json)
		{
			var result = serializer.Deserialize<JsonObj>(json);

			Modules = (result.modules ?? new string[0]).Select(x => new ConfigElement { Path = x, Recursive = x.Contains("**/*") });
			Externals = (result.externals ?? new string[0]).Select(x => new ConfigElement { Path = x });
		}

		protected virtual string GetFullPathContent(string path)
		{
			return File.ReadAllText(Path.GetFullPath(path));
		}
	}

	public struct ConfigElement
	{
		public string Path;
		public bool Recursive;
	}
}
