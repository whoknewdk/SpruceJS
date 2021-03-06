﻿using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Sort;
using Xunit;

namespace SpruceJS.Tests.Core.Sort
{
	public class TopSortTests
	{
		internal struct DataObj
		{
			public string Key;
			public string[] References;
		}

		[Fact]
		public void CanSort()
		{
			var a = new DataObj { Key = "a", References = new string[0] };
			var b = new DataObj { Key = "b", References = new[] { "a" } };
			var c = new DataObj { Key = "c", References = new[] { "a", "b" } };
			var d = new DataObj { Key = "d", References = new[] { "a", "e" } };
			var e = new DataObj { Key = "e", References = new[] { "c", "b" } };

			IList<DataObj> modules = new List<DataObj> { c, d, a, b, e };

			var list = TopSort.Sort(modules, x => x.Key, x => x.References);

			Assert.Equal(5, list.Count());
			Assert.Equal(new List<DataObj> { a, b, c, e, d }, list);
		}
	}
}
