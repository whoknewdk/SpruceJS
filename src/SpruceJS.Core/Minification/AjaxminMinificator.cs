using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Ajax.Utilities;
using SpruceJS.Core.Exceptions.Modules;
using SpruceJS.Core.Exceptions.Sort;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinificator : IMinificator
	{
		public MinifyResult Minify(JSModuleList modules, string appName)
		{
			string definejs;

			// Read embedded JavaScript library
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.define.js"))
			using (var reader = new StreamReader(stream))
				definejs = reader.ReadToEnd();
			
			string result;
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

					sourcemap.StartPackage(appName, appName + ".map");

					var minifier = new Minifier();

					var sb = new StringBuilder();

					// Add definejs
					sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", "define.sp.js"));
					sb.AppendLine(definejs);

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

					result = minifier.MinifyJavaScript(sb.ToString(), settings);

					sourcemap.EndPackage();
				}
			}

			return new MinifyResult {
				JavaScriptBody = result,
				SourceMapBody = sourceMapBuilder.ToString()
			};
		}
	}
}
