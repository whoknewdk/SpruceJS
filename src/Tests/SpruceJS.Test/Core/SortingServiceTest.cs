using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core;
using SpruceJS.Core.Content;
using SpruceJS.Core.Sort;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class SortingServiceTest
	{
		[Fact]
		public void TopologicalSort()
		{
			var a = new ModuleItem { Name = "a" };
			var b = new ModuleItem { Name = "b", Dependencies = new[] { "a" } };
			var c = new ModuleItem { Name = "c", Dependencies = new[] { "a", "b" } };
			var d = new ModuleItem { Name = "d", Dependencies = new[] { "a", "e" } };
			var e = new ModuleItem { Name = "e", Dependencies = new[] { "c", "b" } };

			IList<ModuleItem> modules = new List<ModuleItem>();

			modules.Add(c);
			modules.Add(d);

			modules.Add(a);
			modules.Add(b);
			modules.Add(e);

			var list = TopSort.Sort(modules, x => x.Name, x => x.Dependencies);

			Assert.Equal(5, list.Count());
			Assert.Equal(new List<ModuleItem> { a, b, c, e, d }, list);
		}
	}
}
