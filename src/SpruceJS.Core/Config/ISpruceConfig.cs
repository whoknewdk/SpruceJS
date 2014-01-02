using System.Collections.Generic;

namespace SpruceJS.Core.Config
{
	public interface ISpruceConfig
	{
		IEnumerable<ConfigElement> Externals { get; }
		IEnumerable<ConfigElement> Modules { get; }
		bool IncludeScript { get; }
	}
}
