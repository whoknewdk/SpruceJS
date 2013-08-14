using System;
using System.IO;

namespace SpruceJS.Build
{
	public static class PathUtil
	{
		public static string GetPathDifference(string folderPath, string filePath)
		{
			var file = new Uri(filePath);

			// Must end in a slash to indicate folder
			if (!folderPath.EndsWith("\\"))
				folderPath += "\\";

			var folder = new Uri(folderPath);

			return Uri.UnescapeDataString(
				folder.MakeRelativeUri(file)
					.ToString()
					.Replace('/', Path.DirectorySeparatorChar)
				);
		}
	}
}
