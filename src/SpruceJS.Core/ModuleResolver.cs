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

		public IEnumerable<ModuleItem> fetchModulesOnDisk(ModuleItem module)
		{
			var modules = new List<ModuleItem>();

			// Store keys and dependencies
			keys.Add(module.Name);
			modules.Add(module);

			foreach (var unfoundDependency in module.Dependencies.Except(keys))
			{
				var fileOnDisk = getFullPathForKey(unfoundDependency.Replace("/", "\\") + ".js");
				
				if (!File.Exists(fileOnDisk))
					continue;
				
				var referencedModule = itemFactory.CreateModule(fileOnDisk, unfoundDependency);
				if (referencedModule != null)
					modules.AddRange(fetchModulesOnDisk(referencedModule));
			}

			return modules;
		}

		public string getFullPathForKey(string path)
		{
			return Path.Combine(moduleRootPath, path);
		}
	}
}
