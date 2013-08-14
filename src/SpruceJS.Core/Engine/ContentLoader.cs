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
			// Stop if no file exists
			if (!File.Exists(filePath))
				return null;

			// Read/Analyse file
			return File.ReadAllText(filePath);
		}
	}
}
