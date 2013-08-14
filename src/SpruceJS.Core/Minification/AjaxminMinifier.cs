using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Content;
using SpruceJS.Core.Exceptions.Modules;
using SpruceJS.Core.Exceptions.Sort;
using SpruceJS.Core.Script;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinifier : IMinifier
	{
		public MinifyResult Minify(ModuleItemList modules, IEnumerable<ExternalItem> externals)
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
					}
					catch (NameNotFoundException<ModuleItem> ex)
					{
						throw new ModuleKeyDoesNotExistException(ex.Name, ex.Item.Url);
					}
					catch (NotDirectedAcyclicGraphException<ModuleItem> ex)
					{
						throw new ModuleKeyCircularReferenceException(ex.Items.Select(x => x.Url).ToArray());
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
