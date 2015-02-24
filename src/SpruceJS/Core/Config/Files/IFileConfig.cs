using System.Collections.Generic;

namespace SpruceJS.Core.Config.Files
{
	public interface IFileConfig
	{
		IEnumerable<string> Modules { get; }
		IEnumerable<string> Scripts { get; }
	}
}
