using System.Text;
using SpruceJS.Core.Engine;

namespace SpruceJS.Core.Combiner
{
	public class StandardCombiner : ICombiner
	{
		protected readonly StringBuilder sb = new StringBuilder();

		public virtual void Add(string content, string url)
		{
			sb.AppendLine(content);
		}

		public virtual EngineOutput GetOutput()
		{
			string combinedOutput = sb.ToString().Trim();

			sb.Clear();

			return new EngineOutput { JavaScriptBody = combinedOutput };
		}
	}
}
