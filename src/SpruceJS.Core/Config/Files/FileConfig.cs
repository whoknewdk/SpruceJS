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

				// A file pattern
				if (data.Path.Contains("."))
				{
					list.Add(getFullPath(pathForFileSystem));
				}
				// A directory
				else
				{
					string[] filePaths = Directory.GetFiles(getFullPath(pathForFileSystem), "*",
					                                    data.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
					list.AddRange(filePaths);
				}
			}
		}
	}
}
