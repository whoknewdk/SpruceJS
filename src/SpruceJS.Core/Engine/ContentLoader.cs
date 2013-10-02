using System;
using System.IO;

namespace SpruceJS.Core.Engine
{
	public interface IContentLoader
	{
		string GetContent(string filePath);
		string GetFullPath(string path);
	}

	public class ContentLoader : IContentLoader
	{
		private string projectDirectoryPath;
		private string configDirectoryPath;
		public ContentLoader(string projectDirectoryPath, string configDirectoryPath)
		{
			this.projectDirectoryPath = projectDirectoryPath;
			this.configDirectoryPath = configDirectoryPath;
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

		//
		public string GetFullPath(string path)
		{

			if (path.StartsWith("\\"))
			{
				string pathWithoutBeginnningSlash = path.Substring(1, path.Length - 1);
				return Path.Combine(projectDirectoryPath, pathWithoutBeginnningSlash);
			}

			return Path.Combine(configDirectoryPath, path);
		}
	}
}
