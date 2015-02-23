using System.Collections.Generic;
using System.IO;
using System.Linq;
using SpruceJS.Core.Modules;

namespace SpruceJS.Core
{
	public class ModuleResolver
	{
		readonly HashSet<string> keys = new HashSet<string>();

		readonly string moduleRootPath;
		readonly ItemFactory itemFactory;
		public ModuleResolver(string moduleRootPath, ItemFactory itemFactory)
		{
			this.moduleRootPath = moduleRootPath;
			this.itemFactory = itemFactory;
		}

		public IEnumerable<ModuleItem> FetchModulesOnDisk(ModuleItem module)
		{
			var modules = new List<ModuleItem>();

			// Store keys and dependencies
			keys.Add(module.Name);
			modules.Add(module);

			foreach (var unfoundDependency in module.Dependencies.Except(keys))
			{
				// Full path for key
				var pathOnDisk = Path.Combine(moduleRootPath, unfoundDependency.Replace("/", "\\") + ".js");
				
				// Create module
				var referencedModule = itemFactory.CreateModule(pathOnDisk, unfoundDependency);
				if (referencedModule != null)
					modules.AddRange(FetchModulesOnDisk(referencedModule));
			}

			return modules;
		}
	}
}
