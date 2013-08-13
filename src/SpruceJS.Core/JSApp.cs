using System.IO;
using System.Reflection;
using System.Text;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private readonly JSModuleList modules = new JSModuleList();

		readonly IMinificator minificator;
		public JSApp(IMinificator minificator)
		{
			this.minificator = minificator;
		}

		public void Add(JSModule module)
		{
			modules.Add(module);
		}

		public MinifyResult GetMinifiedOutput()
		{
			return minificator.Minify(modules);
		}

		public string GetOutput()
		{
			// Read embedded JavaScript library
			string definejs;
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.spruce.js"))
			using (var reader = new StreamReader(stream))
				definejs = reader.ReadToEnd();

			var sb = new StringBuilder(definejs);

			foreach (var module in modules)
				sb.Append(module.Content);
			
			return sb.ToString();
		}
	}
}
