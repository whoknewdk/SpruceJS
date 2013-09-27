using System.IO;
using System.Reflection;

namespace SpruceJS.Core.Script
{
	public static class SpruceLib
	{
		private static string amdBody;
		public static string Body
		{
			get { return amdBody ?? (amdBody = load("spruce.js")); }
		}

		private static string cjsBody;
		public static string CjsBody
		{
			get { return cjsBody ?? (cjsBody = load("spruce-common.js")); }
		}

		private static string load(string filename)
		{
			// Read embedded JavaScript library
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script." + filename))
			using (var reader = new StreamReader(stream))
				return reader.ReadToEnd();
		}
	}
}
