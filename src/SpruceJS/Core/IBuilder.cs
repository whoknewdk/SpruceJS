using SpruceJS.Core.Combiner;

namespace SpruceJS.Core
{
	public interface IBuilder
	{
		void LoadModule(string path);
		void LoadConfig(string path);

		CombinerOutput GetOutput();
		bool Minify { get; set; }
	}
}