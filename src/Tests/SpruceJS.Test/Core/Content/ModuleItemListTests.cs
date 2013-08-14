using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Content;
using Xunit;

namespace SpruceJS.Test.Core.Content
{
	public class ModuleItemListTests
	{
		[Fact]
		public void AddAndEnumerateTest()
		{
			var a = new ModuleItem { Name = "a" };
			var b = new ModuleItem { Name = "b", Dependencies = new[] { "a" } };
			var c = new ModuleItem { Name = "c", Dependencies = new[] { "a", "b" } };
			var d = new ModuleItem { Name = "d", Dependencies = new[] { "a", "e" } };
			var e = new ModuleItem { Name = "e", Dependencies = new[] { "c", "b" } };

			var modules = new ModuleItemList { c, d, a, b, e };

			Assert.Equal(5, modules.Count());
			Assert.Equal(new List<ModuleItem> { a, b, c, e, d }, modules.ToList());
		}
	}
}
