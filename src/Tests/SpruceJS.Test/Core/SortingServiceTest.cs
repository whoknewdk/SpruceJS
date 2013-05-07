using System.Collections.Generic;
using SpruceJS.Core;
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

			IDictionary<string, JSModule> Modules = new Dictionary<string, JSModule>();
			
			Modules.Add("c", c);
			Modules.Add("d", d);

			Modules.Add("a", a);
			Modules.Add("b", b);
			Modules.Add("e", e);

			var list = SortingService.Sort(Modules);

			Assert.Equal(5, list.Count);

			Assert.Equal("a", list[0].Name);
			Assert.Equal("b", list[1].Name);
			Assert.Equal("c", list[2].Name);
			Assert.Equal("e", list[3].Name);
			Assert.Equal("d", list[4].Name);
		}
	}
}
