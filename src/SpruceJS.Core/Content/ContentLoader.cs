using System.IO;

namespace SpruceJS.Core.Content
{
	public interface IContentLoader
	{
		string GetContent(string filePath);
		string GetFullPathForKey(string path);
	}

	public class ContentLoader : IContentLoader
	{
		private readonly string projectDirectoryPath;
		public ContentLoader(string projectDirectoryPath)
		{
			this.projectDirectoryPath = projectDirectoryPath;
		}

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

		public string GetFullPathForKey(string path)
		{
			return Path.Combine(projectDirectoryPath, path);
		}
	}
}
