using System;
using System.Collections.Generic;
using System.Xml;

namespace SpruceJS.Core.Config
{
	public class AppConfig : IAppConfig
	{
		public IList<string> Files { get; private set; }
		public IList<Directory> Directories { get; private set; }

		public AppConfig(string config)
		{
			Files = new List<string>();
			Directories = new List<Directory>();

			XmlDocument doc = new XmlDocument();
			doc.LoadXml(config);

			// File references
			foreach (XmlNode node in doc.SelectNodes("//file"))
			{
				Files.Add(node.Attributes["path"].Value);
			}

			// Directory references
			foreach (XmlNode node in doc.SelectNodes("//directory"))
			{
				var dir = new Directory {
					Path = node.Attributes["path"].Value,
				};

				if (node.Attributes["recursive"] != null)
					dir.Recursive = Convert.ToBoolean(node.Attributes["recursive"].Value);
				
				Directories.Add(dir);
			}
		}
	}

	public struct Directory
	{
		public string Path;
		public bool Recursive;
	}
}
