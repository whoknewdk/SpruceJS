using System.Collections.Generic;

namespace SpruceJS.Core.Config.Files
{
	public interface IFileConfig
	{
		IEnumerable<string> Files { get; }
		IEnumerable<string> Externals { get; }
	}
}
