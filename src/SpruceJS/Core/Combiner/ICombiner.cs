
namespace SpruceJS.Core.Combiner
{
	public interface ICombiner
	{
		void Add(string content, string url);
		CombinerOutput GetOutput();
	}
}
