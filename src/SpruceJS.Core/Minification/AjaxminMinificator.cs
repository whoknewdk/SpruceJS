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

		public string Minify(string input)
		{
			MemoryStream memoryStream = new MemoryStream();
			TextWriter tw = new StreamWriter(memoryStream);

			ISourceMap sourcemap = new V3SourceMap(tw);

			var settings = new CodeSettings { SymbolsMap = sourcemap };
			return minifier.MinifyJavaScript(input, settings);
		}
	}
}
