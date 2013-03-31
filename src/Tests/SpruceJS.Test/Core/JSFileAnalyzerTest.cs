using SpruceJS.Core;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class JSFileAnalyzerTest
	{
		[Fact]
		public void CanValidate()
		{
			string text = "define('myid', function () { var abc; });";

			var fileanalyser = new JSFileAnalyzer(text);

			Assert.True(fileanalyser.IsValid);
		}

		[Fact]
		public void CanReadName()
		{
			string text = "define('myid', function () { var abc; });";

			var fileanalyser = new JSFileAnalyzer(text);

			Assert.Equal("'myid'", fileanalyser.Name);
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

			Assert.Equal("'oneid'", fileanalyser.Dependencies[0]);
			Assert.Equal("'twoid'", fileanalyser.Dependencies[1]);
			Assert.Equal("'threeid'", fileanalyser.Dependencies[2]);
		}
	}
}
