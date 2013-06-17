using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinificator : IMinificator
	{
		private string appname, mapname;

		public AjaxminMinificator(string appname)
		{
			this.appname = appname;
			this.mapname = appname + ".map";
		}

		public string Minify(JSModuleList Modules)
		{
			string definejs;

			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.define.js"))
			using (StreamReader reader = new StreamReader(stream))
				definejs = reader.ReadToEnd();
			

			using (StreamWriter sw = new StreamWriter(new FileStream(@"D:\Web\SpruceJS\src\SpruceJS.Web.Sample\" + mapname, FileMode.Create), new UTF8Encoding(false)))
			{

				using(ISourceMap sourcemap = new V3SourceMap(sw))
				{
					CodeSettings settings = new CodeSettings
					{
						SymbolsMap = sourcemap,
						TermSemicolons = true,
						ReorderScopeDeclarations = false
					};

					sourcemap.StartPackage(appname, mapname);

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

					var _result = minifier.MinifyJavaScript(sb.ToString(), settings);

					sourcemap.EndPackage();

					return _result;
				}
			}
		}

		public string SourceMap
		{
			get { return mapname; }
		}
	}
}
