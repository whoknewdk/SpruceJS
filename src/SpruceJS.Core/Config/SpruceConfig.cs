using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SpruceJS.Core.Config
{
	public class SpruceConfig : ISpruceConfig
	{
		public IEnumerable<ConfigElement> Externals { get; private set; }
		public IEnumerable<ConfigElement> Modules { get; private set; }

		public SpruceConfig() { }

		public SpruceConfig(string path)
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
			var doc = new XmlDocument();
			loadDocument(doc);

			Modules = build(doc.SelectNodes("//add[ancestor::modules]"));
			Externals = build(doc.SelectNodes("//add[ancestor::externals]"));
		}

		protected virtual string GetFullPath(string path)
		{
			return Path.GetFullPath(path);
		}

		private IEnumerable<ConfigElement> build(XmlNodeList nodes)
		{
			var list = new List<ConfigElement>();

			foreach (XmlNode node in nodes)
			{
				var data = new ConfigElement
					{
						Path = node.Attributes["path"].Value,
						Recursive = node.Attributes["recursive"] != null && Convert.ToBoolean(node.Attributes["recursive"].Value)
					};

				list.Add(data);
			}

			return list;
		}
	}

	public struct ConfigElement
	{
		public string Path;
		public bool Recursive;
	}
}
