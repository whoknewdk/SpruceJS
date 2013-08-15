
namespace SpruceJS.Core.Engine
{
	public interface IEngine
	{
		IOutput GetOutput();
		bool Minify { get; set; }	}
}
