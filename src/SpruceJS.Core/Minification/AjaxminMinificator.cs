using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinificator : IMinificator
	{
		public MinifyResult Minify(JSModuleList Modules, string appName)
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

					// Add each file
					foreach (var file in Modules)
					{
						sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", file.Url));
						sb.AppendLine(file.Content);
					}

					result = minifier.MinifyJavaScript(sb.ToString(), settings);

					sourcemap.EndPackage();
				}
			}

			return new MinifyResult
			{
				Content = result,
				SourceMap = sourceMapBuilder.ToString()
			};
		}
	}
}
