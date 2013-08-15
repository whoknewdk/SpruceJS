using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Minification
{
	public struct MinifyOutput : IOutput
	{
		public string JavaScriptBody { get; set; }
		public string SourceMapBody { get; set; }
	}
}
