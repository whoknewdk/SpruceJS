using SpruceJS.Core.Engine;

namespace SpruceJS.Core
{
	public interface IBuilder
	{
		IOutput GetOutput();
		bool Minify { get; set; }
	}
}