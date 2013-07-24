using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core.Config.Files
{
	public interface IFileConfig
	{
		IList<string> Files { get; }
	}
}
