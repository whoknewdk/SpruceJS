using System.IO;
using System.Reflection;

namespace SpruceJS.Core.Script
{
	public static class SpruceLib
	{
		private static string body;
		public static string Body
		{
			get { return body ?? (body = load("spruce-define.js")); }
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
