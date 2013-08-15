namespace SpruceJS.Core.Engine
{
	public interface IOutput
	{
		string JavaScriptBody { get; }
		string SourceMapBody { get; }
	}
}
