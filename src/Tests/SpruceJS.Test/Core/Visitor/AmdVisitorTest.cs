using SpruceJS.Core.Visitor;
using Xunit;

namespace SpruceJS.Test.Core.Visitor
{
	public class AmdVisitorTest
	{
		private ModuleVisitor getVisitor(string script)
		{
			var moduleVisitor = new ModuleVisitor();
			moduleVisitor.Load(script);

			return moduleVisitor;
		}

		[Fact]
		public void CanValidate()
		{
			// Leafs
			var a = getVisitor("define('myid', ['id1', 'id2'], function (id1, id2) { var test = 123; });");
			Assert.True(a.IsValid);
			Assert.Equal("myid", a.Indentifier);

			var b = getVisitor("define(['id1','id2'], function (id1, id2) { var test = {}; });");
			Assert.True(b.IsValid);

			var c = getVisitor("define(function () { var test = {}; });");
			Assert.True(c.IsValid);

			var d = getVisitor("define('myid', function (id1, id2) { var test = {}; });");
			Assert.True(d.IsValid);

			// Node
			var e = getVisitor("define('myid', ['id1','id2'], function (id1, id2) { return {}; });");
			Assert.True(e.IsValid);

			var f = getVisitor("define(['id1','id2'], function (id1, id2) { return {}; });");
			Assert.True(f.IsValid);

			var g = getVisitor("define(function () { return {}; });");
			Assert.True(g.IsValid);

			var h = getVisitor("define('myid', function (id1, id2) { return {}; });");
			Assert.True(h.IsValid);
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
			var amdVisitor = getVisitor(text);


			Assert.Equal("myid", amdVisitor.Indentifier);
		}

		[Fact]
		public void CanReadDependencies()
		{
			string text = @"define('myid', ['math', 'world'], function (math, world) { 
								
								function umer (require) {
									require('adel');
								}

								umer(function () { });

								return { };

							});";

			var amdVisitor = getVisitor(text);

			Assert.DoesNotThrow(
				() => { var d = amdVisitor.Dependencies; }
			);

			Assert.Equal(2, amdVisitor.Dependencies.Count);

			Assert.Equal("myid", amdVisitor.Indentifier);
			Assert.Equal("math", amdVisitor.Dependencies[0]);
			Assert.Equal("world", amdVisitor.Dependencies[1]);
		}
	}
}
