using System;
using System.IO;
using System.Text;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinifier : IMinifier
	{
		readonly StringBuilder sb = new StringBuilder();

		public void Add(string content, string url)
		{
			sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", url));
			sb.AppendLine(content);
		}

		public void Clear()
		{
			sb.Clear();
		}

		public EngineOutput Minify()
		{
			var result = new EngineOutput();

			var sourceMapBuilder = new StringBuilder();
			using (var sw = new StringWriter(sourceMapBuilder))
			{
				using(ISourceMap sourcemap = new V3SourceMap(sw))
				{
					var settings = new CodeSettings
					{
						SymbolsMap = sourcemap,
						TermSemicolons = true
					};

					sourcemap.StartPackage("test.js", "test.js" + ".map");

					var minifier = new Minifier();

					result.JavaScriptBody = minifier.MinifyJavaScript(sb.ToString(), settings);

					sourcemap.EndPackage();
				}
			}

			result.SourceMapBody = sourceMapBuilder.ToString();

			return result;
		}
	}
}
