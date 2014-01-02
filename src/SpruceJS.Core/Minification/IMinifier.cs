
using System.Collections.Generic;
using SpruceJS.Core.Content;

namespace SpruceJS.Core.Minification
{
	public interface IMinifier
	{
		MinifyOutput Minify(ModuleItemList modules, IEnumerable<ExternalItem> externals, bool includeScript);
	}
}
