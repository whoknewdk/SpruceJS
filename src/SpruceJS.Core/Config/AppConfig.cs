using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SpruceJS.Core.Config
{
	public class AppConfig : IAppConfig
	{
		public IList<string> Files { get; private set; }
		public IList<Directory> Directories { get; private set; }

		public AppConfig() { }

		public AppConfig(string path)
		{
			Load(path);
		}

		protected void Load(string path)
		{
			Files = new List<string>();
			Directories = new List<Directory>();

			XmlDocument doc = new XmlDocument();
			doc.Load(GetFullPath(path));

			// File references
			foreach (XmlNode node in doc.SelectNodes("//file"))
				Files.Add(node.Attributes["path"].Value);

			// Directory references
			foreach (XmlNode node in doc.SelectNodes("//directory"))
			{
				var dir = new Directory
				{
					Path = node.Attributes["path"].Value,
				};

				if (node.Attributes["recursive"] != null)
					dir.Recursive = Convert.ToBoolean(node.Attributes["recursive"].Value);

				Directories.Add(dir);
			}
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}
	}

	public struct Directory
	{
		public string Path;
		public bool Recursive;
	}
}
