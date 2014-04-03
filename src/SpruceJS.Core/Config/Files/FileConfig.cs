using System.Collections.Generic;
using System.IO;

namespace SpruceJS.Core.Config.Files
{
	public class FileConfig : IFileConfig
	{
		readonly List<string> files = new List<string>();
		readonly List<string> externals = new List<string>();

		public IEnumerable<string> Files { get { return files;  } }
		public IEnumerable<string> Externals { get { return externals; } }

		private readonly string projectDirectoryPath, configFilePath;

		public FileConfig(SpruceConfig appConfig, string projectDirectoryPath, string configFilePath)
		{
			this.projectDirectoryPath = projectDirectoryPath;
			this.configFilePath = configFilePath;

			populateFiles(appConfig.Externals, externals);
			populateFiles(appConfig.Modules, files);
		}

		private void populateFiles(IEnumerable<ConfigElement> dataList, List<string> list)
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

		private string getFullPath(string path)
		{

			if (path.StartsWith("\\"))
			{
				string pathWithoutBeginnningSlash = path.Substring(1, path.Length - 1);
				return Path.Combine(projectDirectoryPath, pathWithoutBeginnningSlash);
			}

			string configDirectoryPath = Path.GetDirectoryName(configFilePath);
			return Path.Combine(configDirectoryPath, path);
		}
	}
}
