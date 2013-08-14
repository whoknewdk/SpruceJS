using System;
using System.Collections.Generic;
using System.IO;

namespace SpruceJS.Core.Config.Files
{
	internal class FileConfig : IFileConfig
	{
		readonly List<string> files = new List<string>();
		readonly List<string> externals = new List<string>();

		public IEnumerable<string> Files { get { return files;  } }
		public IEnumerable<string> Externals { get { return externals; } }

		internal FileConfig(ISpruceConfig appConfig, Func<string, string> getFullPath)
		{
			populateFiles(appConfig.Externals, externals, getFullPath);
			populateFiles(appConfig.Modules, files, getFullPath);
		}

		private void populateFiles(IEnumerable<ConfigElement> dataList, List<string> list, Func<string, string> getFullPath)
		{
			foreach (ConfigElement data in dataList)
			{
				string pathForFileSystem = data.Path.Replace("/", "\\");
				string fullPath = getFullPath(pathForFileSystem);
				var option = data.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

				if (Directory.Exists(fullPath))
				{
					string[] filePaths = Directory.GetFiles(fullPath, "*", option);
					list.AddRange(filePaths);
				}
				else
				{
					string directoryName = Path.GetDirectoryName(fullPath);
					string fileName = Path.GetFileName(fullPath);

					string[] filePaths = Directory.GetFiles(directoryName, fileName, option);
					list.AddRange(filePaths);
				}
			}
		}
	}
}
