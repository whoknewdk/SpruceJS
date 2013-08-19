using SpruceJS.Core.Analyzer;
using Xunit;

namespace SpruceJS.Test.Core.Analyzer
{
	public class ModuleStrutureAnalyzerTest
	{
		[Fact]
		public void CanValidate()
		{
			// Leafs
			var a = new AMDStructureAnalyzer("define('myid', ['id1', 'id2'], function (id1, id2) { var test = 123; });");
			Assert.True(a.IsValid);
			Assert.Equal("myid", a.Name);

			var b = new AMDStructureAnalyzer("define(['id1','id2'], function (id1, id2) { var test = {}; });");
			Assert.True(b.IsValid);

			var c = new AMDStructureAnalyzer("define(function () { var test = {}; });");
			Assert.True(c.IsValid);

			var d = new AMDStructureAnalyzer("define('myid', function (id1, id2) { var test = {}; });");
			Assert.True(d.IsValid);

			// Node
			var e = new AMDStructureAnalyzer("define('myid', ['id1','id2'], function (id1, id2) { return {}; });");
			Assert.True(e.IsValid);

			var f = new AMDStructureAnalyzer("define(['id1','id2'], function (id1, id2) { return {}; });");
			Assert.True(f.IsValid);

			var g = new AMDStructureAnalyzer("define(function () { return {}; });");
			Assert.True(g.IsValid);

			var h = new AMDStructureAnalyzer("define('myid', function (id1, id2) { return {}; });");
			Assert.True(h.IsValid);
		}

		[Fact]
		public void CanNotValidate()
		{
			var a = new AMDStructureAnalyzer("define();");
			Assert.False(a.IsValid);

			var b = new AMDStructureAnalyzer("define('id1');");
			Assert.False(b.IsValid);

			var c = new AMDStructureAnalyzer("define('id1', ['id2', 'id3']);");
			Assert.False(c.IsValid);

			var d = new AMDStructureAnalyzer("define(['id2', 'id3']);");
			Assert.False(d.IsValid);
		}

		[Fact]
		public void CanReadName()
		{
			string text = "define('myid', function () { var abc; });";

			var fileanalyser = new AMDStructureAnalyzer(text);

			Assert.Equal("myid", fileanalyser.Name);
		}

		[Fact]
		public void CanReadDependencies()
		{
			string text = "define('myid', ['oneid', 'twoid','threeid'], function () { var abc; });";

			var fileanalyser = new AMDStructureAnalyzer(text);

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
