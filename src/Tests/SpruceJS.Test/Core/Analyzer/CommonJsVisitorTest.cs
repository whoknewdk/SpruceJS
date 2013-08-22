using SpruceJS.Core.Analyzer;
using Xunit;

namespace SpruceJS.Test.Core.Analyzer
{
	public class CommonJsVisitorTest
	{
		private CommonJsVisitor getVisitor(string script)
		{
			var commonJsVisitor = new CommonJsVisitor();
			commonJsVisitor.Load(script);

			return commonJsVisitor;
		}

		[Fact]
		public void CanValidate()
		{
			// Leafs
			var a = getVisitor("define('myid', function (id1, id2) { var test = 123; });");
			Assert.True(a.IsValid);
			Assert.Equal("myid", a.Indentifier);

			var c = getVisitor("define(function () { var test = {}; });");
			Assert.True(c.IsValid);

			var d = getVisitor("define('myid', function (id1, id2) { id1('test'); });");
			Assert.True(d.IsValid);
		}

		[Fact]
		public void CanNotValidate()
		{
			var a = getVisitor("define();");
			Assert.False(a.IsValid);

			var b = getVisitor("define('id1');");
			Assert.False(b.IsValid);

			var c = getVisitor("define('id1', ['id2', 'id3']);");
			Assert.False(c.IsValid);

			var d = getVisitor("define(['id2', 'id3']);");
			Assert.False(d.IsValid);
		}

		[Fact]
		public void CanReadName()
		{
			string text = "define('myid', function () { var abc; });";

			var commonJsVisitor = getVisitor(text);

			Assert.Equal("myid", commonJsVisitor.Indentifier);
		}

		[Fact]
		public void CanReadDependencies()
		{
			string text = @"define('myid', function (require, exports) { 
								var abc = require('math'); 
								var abc2 = require('world'); 

								function umer (require) {
									require('adel');
								}

								umer(function () { });

							});";

			var commonJsVisitor = getVisitor(text);

			Assert.DoesNotThrow(
				() => { var d = commonJsVisitor.Dependencies; }
			);

			Assert.Equal(2, commonJsVisitor.Dependencies.Count);

			Assert.Equal("myid", commonJsVisitor.Indentifier);
			Assert.Equal("math", commonJsVisitor.Dependencies[0]);
			Assert.Equal("world", commonJsVisitor.Dependencies[1]);
		}
	}
}
