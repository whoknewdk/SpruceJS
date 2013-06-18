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

		public void LoadXml(string content)
		{
			loadDirectoriesAndFile(doc => doc.LoadXml(content));
		}

		public void Load(string path)
		{
			loadDirectoriesAndFile(doc => doc.Load(GetFullPath(path)));
		}

		private void loadDirectoriesAndFile(Action<XmlDocument> loadDocument)
		{
			Files = new List<string>();
			Directories = new List<Directory>();

			XmlDocument doc = new XmlDocument();
			loadDocument(doc);

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
