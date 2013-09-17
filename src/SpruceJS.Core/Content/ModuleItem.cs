using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpruceJS.Core.Content
{
	public class ModuleItem : ExternalItem
	{
		public string Name { get; set; }
		public IList<string> Dependencies { get; set; }

		public ModuleItem() { }
		public ModuleItem(string name, IList<string> dependencies)
		{
			Name = name;
			Dependencies = dependencies;

			// Modules without name should use dependencies as is
			if (!String.IsNullOrEmpty(Name))
			{
				var nameParts = Name.Split('/');
				for (int i = 0; i < dependencies.Count; i++)
				{
					var dependency = dependencies[i];

					if (dependency.StartsWith("./"))
					{
						var listWithoutLast = nameParts.Take(nameParts.Length - 1).ToList();
						listWithoutLast.Add(dependency.Replace("./", ""));
						dependencies[i] = string.Join("/", listWithoutLast);
					}

					if (dependency.StartsWith("../"))
					{
						var dependencyParts = Regex.Split(dependency, "../");
						var listWithoutLast = nameParts.Take(nameParts.Length - dependencyParts.Length).ToList();
						listWithoutLast.Add(dependencyParts[dependencyParts.Length - 1]);
						dependencies[i] = string.Join("/", listWithoutLast);
					}
				}
			}
		}
	}
}
