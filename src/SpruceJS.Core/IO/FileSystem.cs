using System.IO;

namespace SpruceJS.Core.IO
{
	public interface IFileSystem
	{
		string ReadAllText(string path);
	}

	public class FileSystem : IFileSystem
	{
		public string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}
	}
}
