
using System.Collections.Generic;
using SpruceJS.Core.Content;

namespace SpruceJS.Core.Minification
{
	public interface IMinificator
	{
		MinifyResult Minify(JSModuleList modules, IEnumerable<ExternalItem> externals);
	}
}
