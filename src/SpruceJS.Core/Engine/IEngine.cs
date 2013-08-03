using SpruceJS.Core.Results;

namespace SpruceJS.Core.Engine
{
	public interface IEngine
	{
		IResult Render(string appName);
	}
}
