using System.IO;
using System.Reflection;

namespace SpruceJS.Core.Script
{
	public static class SpruceLib
	{
		private static string body;

		public static string Body
		{
			get
			{
				// Read embedded JavaScript library
				if (body == null)
				{
					using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SpruceJS.Core.Script.spruce.js"))
					using (var reader = new StreamReader(stream))
						body = reader.ReadToEnd();
				}

				return body;
			}
		}
	}
}
