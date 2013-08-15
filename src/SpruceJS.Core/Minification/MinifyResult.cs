using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Minification
{
	public struct MinifyResult : IResult
	{
		public string JavaScriptBody { get; set; }
		public string SourceMapBody { get; set; }
	}
}
