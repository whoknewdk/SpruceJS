using System;
using System.IO;
using System.Text;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Exceptions.Modules;
using SpruceJS.Core.Exceptions.Sort;
using SpruceJS.Core.Script;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinificator : IMinificator
	{
		public MinifyResult Minify(JSModuleList modules)
		{
			MinifyResult result = new MinifyResult();
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
					sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", "define.sp.js"));
					sb.AppendLine(SpruceLib.Body);

					try
					{
						// Add each file
						foreach (var file in modules)
						{
							sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", file.Url));
							sb.AppendLine(file.Content);
						}
					}
					catch (NameNotFoundException<JSModule> ex)
					{
						throw new ModuleKeyDoesNotExistException(ex.Name, ex.Item.Url);
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
