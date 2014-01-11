using System.Collections.Generic;
using System.IO;
using SpruceJS.Core.Content;

namespace SpruceJS.Core.Config.Files
{
	public class FileConfig : IFileConfig
	{
		readonly List<string> files = new List<string>();
		readonly List<string> externals = new List<string>();

		public IEnumerable<string> Files { get { return files;  } }
		public IEnumerable<string> Externals { get { return externals; } }

		private readonly IContentLoader loader;

		public FileConfig(ISpruceConfig appConfig, IContentLoader loader)
		{
			this.loader = loader;

			populateFiles(appConfig.Externals, externals);
			populateFiles(appConfig.Modules, files);
		}

		private void populateFiles(IEnumerable<ConfigElement> dataList, List<string> list)
		{
			foreach (ConfigElement data in dataList)
			{
				string pathForFileSystem = data.Path.Replace("/", "\\");
				string fullPath = loader.GetFullPath(pathForFileSystem);
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
