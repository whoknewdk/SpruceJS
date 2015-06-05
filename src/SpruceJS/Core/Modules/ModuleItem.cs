using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpruceJS.Core.Modules
{
	public class ModuleItem : ExternalItem
	{
		public string Name { get; private set; }
		public string[] Dependencies { get; private set; }

		public ModuleItem(string url, string content, string name)
			: this(url, content, name, new string[0])
		{
			
		}

		public ModuleItem(string url, string content, string name, string[] dependencies) 
			: base(url, content)
		{
			Name = name;
			Dependencies = dependencies;

			// Modules without name should use dependencies as is
			if (String.IsNullOrEmpty(Name))
				return;
			
			var nameParts = Name.Split('/');
			for (int i = 0; i < dependencies.Length; i++)
			{
				var dependency = dependencies[i];

				// Current path
				if (dependency.StartsWith("./"))
				{
					var listWithoutLast = nameParts.Take(nameParts.Length - 1).ToList();
					listWithoutLast.Add(dependency.Replace("./", ""));
					dependencies[i] = string.Join("/", listWithoutLast);
				}

				// Move levelse out
				if (dependency.StartsWith("../"))
				{
					var dependencyParts = Regex.Split(dependency, Regex.Escape("../"));
					var listWithoutLast = nameParts.Take(nameParts.Length - dependencyParts.Length).ToList();
					listWithoutLast.Add(dependencyParts[dependencyParts.Length - 1]);
					dependencies[i] = string.Join("/", listWithoutLast);
				}
			}
		}
	}
}
