using System;
using System.Collections.Generic;
using System.IO;

namespace SpruceJS.Core.Config.Files
{
	public class FileConfig : IFileConfig
	{
		public IList<string> Files { get; private set; } 

		public FileConfig(IAppConfig appConfig, Func<string, string> getFullPath)
		{
			Files = new List<string>();

			populateFiles(appConfig.Externals, getFullPath);
			populateFiles(appConfig.Modules, getFullPath);
		}

		private void populateFiles(IEnumerable<Data> list, Func<string, string> getFullPath)
		{
			foreach (Data data in list)
			{
				// A file pattern
				if (data.Path.Contains("."))
					Files.Add(getFullPath(data.Path));

				// An directory
				else
				{
					string[] files = Directory.GetFiles(getFullPath(data.Path), "*", data.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
					foreach (var file in files)
						Files.Add(file);
				}
			}
		}
	}
}
