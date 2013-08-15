
namespace SpruceJS.Core.Engine
{
	public interface IEngine
	{
		IResult Render();
		bool Minify { get; set; }	}
}
