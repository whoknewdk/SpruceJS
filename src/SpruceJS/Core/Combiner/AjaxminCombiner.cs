using System;
using System.IO;
using System.Text;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Combiner
{
	public class AjaxminCombiner : ICombiner
	{
		public bool MinifyCode { get; set; }

        protected readonly StringBuilder sb = new StringBuilder();

		public AjaxminCombiner()
		{
			MinifyCode = true;
		}

		public void Add(string content, string url)
		{
			sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", url));
			sb.AppendLine(content);
        }

		public CombinerOutput GetOutput()
		{
			string combinedOutput = sb.ToString();

			sb.Clear();

			string minifiedJavaScript;
			var sourceMapBuilder = new StringBuilder();
			using (var sw = new StringWriter(sourceMapBuilder))
			{
				using(ISourceMap sourcemap = new V3SourceMap(sw))
				{
					var settings = new CodeSettings {
						SymbolsMap = sourcemap,
						TermSemicolons = true,
						MinifyCode = MinifyCode
					};

					sourcemap.StartPackage("test.js", "");

					var minifier = new Minifier();

					minifiedJavaScript = minifier.MinifyJavaScript(combinedOutput, settings);

					sourcemap.EndPackage();
				}
			}

			return new CombinerOutput
			{
				JavaScriptBody = minifiedJavaScript,
				SourceMapBody = sourceMapBuilder.ToString()
			};
		}
	}
}
