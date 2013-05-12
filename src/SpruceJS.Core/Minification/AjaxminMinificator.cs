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
		Minifier minifier = new Minifier();

		ISourceMap sourcemap;
		CodeSettings settings;

		StreamWriter sw;

		public AjaxminMinificator()
		{
			sw = new StreamWriter(Path.Combine(@"D:\Web\SpruceJS\src\SpruceJS.Web.Sample", "app.spruce.js.map"), false, new UTF8Encoding(false));
			sourcemap = new V3SourceMap(sw);
			settings = new CodeSettings { SymbolsMap = sourcemap };

			settings.TermSemicolons = true;

			sourcemap.StartPackage("app.spruce.js.map", "");
			sourcemap.SourceRoot = "/demo";
		}

		public string Minify(string input, string name)
		{
			try
			{
				minifier.FileName = name.Replace("\"", "") + ".js";
				return minifier.MinifyJavaScript(input, settings);
			}
			catch (Exception ex)
			{
				this.Close();
				throw ex;
			}
		}

		public void Close()
		{
			sourcemap.EndPackage();
			sourcemap.Dispose();
		}
	}
}
