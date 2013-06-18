using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core.Minification
{
	public interface IMinificator
	{
		MinifyResult Minify(JSModuleList Modules, string appName);
	}
}
