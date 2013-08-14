using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using SpruceJS.Core.Content;
using SpruceJS.Core.Minification;

namespace SpruceJS.Core
{
	public class JSApp
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		readonly IMinifier minificator;
		public JSApp(IMinifier minificator)
		{
			this.minificator = minificator;
		}

		public void AddModule(ModuleItem module)
		{
			modules.Add(module);
		}

		public void AddExternal(ExternalItem external)
		{
			externals.Add(external);
		}

		public MinifyResult GetMinifiedOutput()
		{
			return minificator.Minify(modules, externals);
		}

		public string GetOutput()
		{
			// Read embedded JavaScript library
			string definejs;
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.spruce.js"))
			using (var reader = new StreamReader(stream))
				definejs = reader.ReadToEnd();

			var sb = new StringBuilder(definejs);

			foreach (var external in externals)
				sb.Append(external.Content);

			foreach (var module in modules)
				sb.Append(module.Content);
			
			return sb.ToString();
		}
	}
}
