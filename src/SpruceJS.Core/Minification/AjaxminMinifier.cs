using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Content;
using SpruceJS.Core.Script;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinifier : IMinifier
	{
		public MinifyOutput Minify(ModuleItemList modules, IEnumerable<ExternalItem> externals, bool includeScript)
		{
			MinifyOutput result = new MinifyOutput();
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

					var sb = new StringBuilder();

					// Add definejs
					if (includeScript)
					{
						sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", "spruce-define.spruce.js"));
						sb.AppendLine(SpruceLib.Body);
					}

					// Add each file
					foreach (var external in externals)
					{
						sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", external.Url));
						sb.AppendLine(external.Content);
					}

					// Add each file
					foreach (var module in modules)
					{
						sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", module.Url));
						sb.AppendLine(module.Content);
					}

					result.JavaScriptBody = minifier.MinifyJavaScript(sb.ToString(), settings);

					sourcemap.EndPackage();
				}
			}

			result.SourceMapBody = sourceMapBuilder.ToString();

			return result;
		}
	}
}
