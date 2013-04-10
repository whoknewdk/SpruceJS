using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core.Config
{
	public interface IAppConfig
	{
		IList<string> Files { get; }
		IList<Directory> Directories { get; }
	}
}
