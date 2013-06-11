using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Ajax.Utilities;

namespace SpruceJS.Core.Minification
{
	public class AjaxminMinificator : IMinificator
	{
		ISourceMap sourcemap;
		CodeSettings settings;

		StreamWriter sw;

		private string realMapName;

		Random rnd = new Random();

		Minifier minifier;
		public AjaxminMinificator(string appname)
		{
			realMapName = appname + ".map";

			sw = new StreamWriter(new FileStream(@"D:\Web\SpruceJS\src\SpruceJS.Web.Sample\" + realMapName, FileMode.Create), new UTF8Encoding(false));
			
			sourcemap = new V3SourceMap(sw);
			//sourcemap.SourceRoot = "/demo";

			settings = new CodeSettings { 
				SymbolsMap = sourcemap
			};

			sourcemap.StartPackage(appname, "");
			
			minifier = new Minifier();
		}

		public string Minify(Dictionary<string, string> list)
		{
			try
			{
				StringBuilder sb = new StringBuilder();

				foreach (var file in list)
				{
					sb.AppendLine(String.Format(";///#SOURCE 1 1 {0}", file.Key));
					sb.AppendLine(file.Value);
				}

				return minifier.MinifyJavaScript(sb.ToString(), settings);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.Close();
			}
		}

		public void Close()
		{
			sourcemap.EndPackage();
			sourcemap.Dispose();

			sw.Close();
		}

		public string SourceMap
		{
			get { return realMapName; }
		}
	}
}
