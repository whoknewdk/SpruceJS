using SpruceJS.Core.Combiner;

namespace SpruceJS.Core
{
	public interface IBuilder
	{
		void LoadJS(string jsFilePath, string projectDirPath);
		void LoadConfig(string confileFilePath, string projectDirPath);

		CombinerOutput GetOutput();
		bool Minify { get; set; }
	}
}