
namespace SpruceJS.Core.Engine
{
	public struct EngineResult : IResult
	{
		public string JavaScriptBody { get; set; }
		public string SourceMapBody { get; set; }
	}
}
