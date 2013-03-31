using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpruceJS.Core
{
	public class Engine
	{
		public Engine(AppConfig config)
		{
			var app = new JSApp();

			foreach (var file in config.Files)
				app.Add(create(file));
		}

		private JSModule create (string file)
		{
			// Get actual file path on server
			//string filePath = HttpContext.Current.Server.MapPath(file);
			string filePath = "";
			string content = File.ReadAllText(filePath);

			var fileAnalyzer = new JSFileAnalyzer(content);

			if (fileAnalyzer.IsValid) 
			{
				
			}

			return new JSModule {
				Name = fileAnalyzer.Name,
				Dependencies = fileAnalyzer.Dependencies,
				Content = content
			};
		}
	}
}
