using System;
using System.IO;

namespace SpruceJS.Core.Engine
{
	public interface IContentLoader
	{
		string GetContent(string filePath);
	}

	public class ContentLoader : IContentLoader
	{
		public string GetContent(string filePath)
		{
			try
			{
				// Read/Analyse file
				return File.ReadAllText(filePath);
			}
			catch (FileNotFoundException)
			{
				return null;
			}
		}
	}
}
