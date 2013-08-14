
using System.Collections.Generic;
using SpruceJS.Core.Content;

namespace SpruceJS.Core.Minification
{
	public interface IMinifier
	{
		MinifyResult Minify(ModuleItemList modules, IEnumerable<ExternalItem> externals);
	}
}
