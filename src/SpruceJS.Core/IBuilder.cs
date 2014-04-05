using SpruceJS.Core.Combiner;

namespace SpruceJS.Core
{
	public interface IBuilder
	{
		void LoadJS(string jsFilePath);
		void LoadConfig(string confileFilePath);

		CombinerOutput GetOutput();
		bool Minify { get; set; }
	}
}