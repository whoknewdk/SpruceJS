
using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Minification
{
	public interface IMinifier
	{
		void Add(string content, string url);
		void Clear();
		EngineOutput Minify();
	}
}
