using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SpruceJS.Core
{
	public class AppConfig
	{
		public IList<string> Files = new List<string>();
		public IList<Directory> Directories = new List<Directory>();

		public AppConfig(string config)
		{
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
