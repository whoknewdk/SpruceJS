using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SpruceJS.Core.Config
{
	public class AppConfig : IAppConfig
	{
		public IList<Data> Externals { get; private set; }
		public IList<Data> Modules { get; private set; }

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
			Modules = new List<Data>();
			Externals = new List<Data>();

			var doc = new XmlDocument();
			loadDocument(doc);

			// File references
			foreach (XmlNode node in doc.SelectNodes("//add[ancestor::modules]"))
			{
				var data = new Data { Path = node.Attributes["path"].Value };

				if (node.Attributes["recursive"] != null)
					data.Recursive = Convert.ToBoolean(node.Attributes["recursive"].Value);
				else
					data.Recursive = false;

				Modules.Add(data);
			}

			// Directory references
			foreach (XmlNode node in doc.SelectNodes("//add[ancestor::externals]"))
			{
				var data = new Data { Path = node.Attributes["path"].Value };

				if (node.Attributes["recursive"] != null)
					data.Recursive = Convert.ToBoolean(node.Attributes["recursive"].Value);
				else
					data.Recursive = false;

				Externals.Add(data);
			}
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}
	}

	public struct Data
	{
		public string Path;
		public bool Recursive;
	}
}
