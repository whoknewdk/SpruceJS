using System.Collections.Generic;

namespace SpruceJS.Core.Config
{
	public interface IAppConfig
	{
		IList<Data> Externals { get; }
		IList<Data> Modules { get; }
	}
}
