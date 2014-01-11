using SpruceJS.Core.Combiner;

namespace SpruceJS.Core
{
	public interface IBuilder
	{
		CombinerOutput GetOutput();
		bool Minify { get; set; }
	}
}