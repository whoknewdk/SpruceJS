﻿using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Script;
using SpruceJS.Core.Sort;
using Xunit;

namespace SpruceJS.Test.Core.Sort
{
	public class ScriptLibTests
	{
		[Fact]
		public void JsLibraryExists()
		{
			Assert.NotNull(SpruceLib.Body);
			Assert.Contains("define", SpruceLib.Body);
		}
	}
}