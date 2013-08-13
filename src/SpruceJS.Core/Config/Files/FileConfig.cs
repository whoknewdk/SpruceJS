using System;
using System.Collections.Generic;
using System.IO;

namespace SpruceJS.Core.Config.Files
{
	public class FileConfig : IFileConfig
	{
		public IList<string> Files { get; private set; } 

		public FileConfig(ISpruceConfig appConfig, Func<string, string> getFullPath)
		{
			Files = new List<string>();

			populateFiles(appConfig.Externals, getFullPath);
			populateFiles(appConfig.Modules, getFullPath);
		}

		private void populateFiles(IEnumerable<Data> list, Func<string, string> getFullPath)
		{
			foreach (Data data in list)
			{
				string pathForFileSystem = data.Path.Replace("/", "\\");

				// A file pattern
				if (data.Path.Contains("."))
				{
					Files.Add(getFullPath(pathForFileSystem));
				}
				// A directory
				else
				{
					string[] files = Directory.GetFiles(getFullPath(pathForFileSystem), "*",
					                                    data.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
					foreach (var file in files)
						Files.Add(file);
				}
			}
		}
	}
}
