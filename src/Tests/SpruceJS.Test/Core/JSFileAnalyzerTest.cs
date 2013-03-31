using SpruceJS.Core;
using Xunit;

namespace SpruceJS.Test.Core
{
	public class JSFileAnalyzerTest
	{
		[Fact]
		public void FileAnalyzerGetNameTest()
		{
			string text = "define('myid', function () { var abc; });";

			var fileanalyser = new JSFileAnalyzer(text);

			Assert.Equal("'myid'", fileanalyser.Name);
		}
	}
}
