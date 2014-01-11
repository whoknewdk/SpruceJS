using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Combiner
{
	public interface ICombiner
	{
		void Add(string content, string url);
		EngineOutput GetOutput();
	}
}
