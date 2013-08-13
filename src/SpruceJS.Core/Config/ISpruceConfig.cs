using System.Collections.Generic;

namespace SpruceJS.Core.Config
{
	public interface ISpruceConfig
	{
		IList<Data> Externals { get; }
		IList<Data> Modules { get; }
	}
}
