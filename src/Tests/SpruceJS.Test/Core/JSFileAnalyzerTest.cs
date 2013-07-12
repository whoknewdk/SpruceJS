using SpruceJS.Core;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class JSFileAnalyzerTest
	{
		[Fact]
		public void CanValidate()
		{
			// Leafs
			var a = new JSFileAnalyzer("define('myid', ['id1', 'id2'], function (id1, id2) { var test = 123; });");
			Assert.True(a.IsValid);
			Assert.Equal("myid", a.Name);

			//var b = new JSFileAnalyzer("define(['id1','id2'], function (id1, id2) { var test = {}; });");
			//Assert.True(b.IsValid);

			//var c = new JSFileAnalyzer("define(function () { var test = {}; });");
			//Assert.True(c.IsValid);

			//var d = new JSFileAnalyzer("define('myid', function (id1, id2) { var test = {}; });");
			//Assert.True(d.IsValid);

			// Node
			var e = new JSFileAnalyzer("define('myid', ['id1','id2'], function (id1, id2) { return {}; });");
			Assert.True(e.IsValid);

			//var f = new JSFileAnalyzer("define(['id1','id2'], function (id1, id2) { return {}; });");
			//Assert.True(f.IsValid);

			//var g = new JSFileAnalyzer("define(function () { return {}; });");
			//Assert.True(g.IsValid);

			//var h = new JSFileAnalyzer("define('myid', function (id1, id2) { return {}; });");
			//Assert.True(h.IsValid);
		}

		[Fact]
		public void CanReadName()
		{
			string text = "define('myid', function () { var abc; });";

			var fileanalyser = new JSFileAnalyzer(text);

			Assert.Equal("myid", fileanalyser.Name);
		}

		[Fact]
		public void CanReadDependencies()
		{
			string text = "define('myid', ['oneid', 'twoid','threeid'], function () { var abc; });";

			var fileanalyser = new JSFileAnalyzer(text);

			Assert.DoesNotThrow(
				() => { var d = fileanalyser.Dependencies; }
			);

			Assert.Equal(3, fileanalyser.Dependencies.Count);

			Assert.Equal("oneid", fileanalyser.Dependencies[0]);
			Assert.Equal("twoid", fileanalyser.Dependencies[1]);
			Assert.Equal("threeid", fileanalyser.Dependencies[2]);
		}
	}
}
