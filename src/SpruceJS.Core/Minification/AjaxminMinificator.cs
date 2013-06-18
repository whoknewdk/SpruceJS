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
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.define.js"))
			using (StreamReader reader = new StreamReader(stream))
				definejs = reader.ReadToEnd();
			
			string result;
			StringBuilder sourceMapBuilder = new StringBuilder();
			using (StringWriter sw = new StringWriter(sourceMapBuilder))
			{

				using(ISourceMap sourcemap = new V3SourceMap(sw))
				{
					CodeSettings settings = new CodeSettings
					{
						SymbolsMap = sourcemap,
						TermSemicolons = true
					};

					sourcemap.StartPackage(appName, appName + ".map");

					Minifier minifier = new Minifier();

					StringBuilder sb = new StringBuilder();

					// Add definejs
					sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", "define.sp.js"));
					sb.AppendLine(definejs);

					// Add each file
					foreach (var file in Modules)
					{
						sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", file.FileName));
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
