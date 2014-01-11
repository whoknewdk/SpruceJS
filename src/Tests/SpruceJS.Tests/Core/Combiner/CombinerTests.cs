using System;
using SpruceJS.Core.Combiner;
using Xunit;

namespace SpruceJS.Tests.Core.Combiner
{
	public class CombinerTests
	{
		[Fact]
		public void StandardCanCombineAndReset()
		{
			ICombiner combiner = new StandardCombiner();

			combiner.Add("var a = 1;", "url");
			combiner.Add("var b = 2;", "url");

			// Output is combined
			Assert.Equal("var a = 1;" + Environment.NewLine + "var b = 2;", combiner.GetOutput().JavaScriptBody);
			
			// Output is now empty
			Assert.Equal(String.Empty, combiner.GetOutput().JavaScriptBody);
		}

		[Fact]
		public void AjaxminCanCombineAndReset()
		{
			ICombiner combiner = new AjaxminCombiner();

			combiner.Add("var a = 1;", "url");
			combiner.Add("var b = 2;", "url");

			// Output is combined
			Assert.Equal("var a=1,b=2;", combiner.GetOutput().JavaScriptBody);

			// Output is now empty
			Assert.Equal(String.Empty, combiner.GetOutput().JavaScriptBody);
		}
	}
}
