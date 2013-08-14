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
			var a = new JSModule { Name = "a" };
			var b = new JSModule { Name = "b", Dependencies = new[] { "a" } };
			var c = new JSModule { Name = "c", Dependencies = new[] { "a", "b" } };
			var d = new JSModule { Name = "d", Dependencies = new[] { "a", "e" } };
			var e = new JSModule { Name = "e", Dependencies = new[] { "c", "b" } };

			IList<JSModule> modules = new List<JSModule>();

			modules.Add(c);
			modules.Add(d);

			modules.Add(a);
			modules.Add(b);
			modules.Add(e);

			var list = SortingService.Sort(modules, x => x.Name, x => x.Dependencies);

			Assert.Equal(5, list.Count());
			Assert.Equal(new List<JSModule> { a, b, c, e, d }, list);
		}
	}
}
