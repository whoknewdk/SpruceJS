﻿using System.Collections.Generic;

namespace SpruceJS.Core.Content
{
	public class ModuleItem : ExternalItem
	{
		public string Name { get; set; }
		public IList<string> Dependencies = new List<string>();
	}
}