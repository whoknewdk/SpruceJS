using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Content;
using Xunit;

namespace SpruceJS.Test.Core.Content
{
	public class ModuleItemListTests
	{
		[Fact]
		public void CanAddAndEnumerateModules()
		{
			var a = new ModuleItem("a", "", "a", new string[0]);
			var b = new ModuleItem("b", "", "b", new[] { "a" });
			var c = new ModuleItem("c", "", "c", new[] { "a", "b" });
			var d = new ModuleItem("d", "", "d", new[] { "a", "e" });
			var e = new ModuleItem("e", "", "e", new[] { "c", "b" });

			var modules = new ModuleItemList { c, d, a, b, e };

			Assert.Equal(5, modules.Count());
			Assert.Equal(new List<ModuleItem> { a, b, c, e, d }, modules.ToList());
		}

		[Fact]
		public void EachModuleIsOnlyPresentOnce()
		{
			var a1 = new ModuleItem("a", "", "a");
			var a2 = new ModuleItem("a", "", "a");

			var modules = new ModuleItemList { a1, a2 };

			Assert.Equal(1, modules.Count());
			Assert.Equal(new List<ModuleItem> { a1 }, modules.ToList());
			Assert.Equal(new List<ModuleItem> { a2 }, modules.ToList());
		}
	}
}
