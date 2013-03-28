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


		public AppConfig()
		{ }


		public AppConfig(string config)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(config);

			// File references
			foreach (XmlNode node in doc.SelectNodes("//file"))
			{
				Files.Add(node.Attributes["path"].Value);
			}
		}
	}
}
