using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Exceptions.Sort;
using SpruceJS.Core.Sort;
using Xunit;

namespace SpruceJS.Test.Core.Sort
{
	public class TopSortExceptionTests
	{
		internal struct DataObj
		{
			public string Key;
			public string[] References;
		}

		[Fact]
		public void SortThrowsNameNotFoundException()
		{
			var a = new DataObj { Key = "a", References = new string[0] };
			var b = new DataObj { Key = "b", References = new[] { "a" } };
			var c = new DataObj { Key = "c", References = new[] { "a", "b" } };
			var d = new DataObj { Key = "d", References = new[] { "a", "e" } };
			var e = new DataObj { Key = "e", References = new[] { "c", "b", "F" } };

			IList<DataObj> modules = new List<DataObj> { c, d, a, b, e };

			Assert.Throws<NameNotFoundException<DataObj>>(
				() => { TopSort.Sort(modules, x => x.Key, x => x.References).ToList(); }
			);
		}

		[Fact]
		public void SortThrowsNotDirectedAcyclicGraphException()
		{
			var a = new DataObj { Key = "a", References = new[] { "e" } };
			var b = new DataObj { Key = "b", References = new[] { "a" } };
			var c = new DataObj { Key = "c", References = new[] { "a", "b" } };
			var d = new DataObj { Key = "d", References = new[] { "a", "e" } };
			var e = new DataObj { Key = "e", References = new[] { "c", "b" } };

			IList<DataObj> modules = new List<DataObj> { c, d, a, b, e };

			Assert.Throws<NotDirectedAcyclicGraphException<DataObj>>(
				() => { TopSort.Sort(modules, x => x.Key, x => x.References).ToList(); }
			);
		}
	}
}
