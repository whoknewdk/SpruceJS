namespace SpruceJS.Core.Engine
{
	public interface IResult
	{
		string JavaScriptBody { get; }
		string SourceMapBody { get; }
	}
}
