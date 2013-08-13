using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Build
{
	public class PublishSpruce : AppDomainIsolatedTask
	{
		public string ProjectDir { get; set; }
		public string BaseIntermediateOutputPath { get; set; }

		private const string spruceKey = "SpruceTemp";

		public override bool Execute()
		{
			BaseIntermediateOutputPath = @"D:\Web\SpruceJS\src\SpruceJS.Web.Sample\obj\";
			string tempDir = Path.Combine(BaseIntermediateOutputPath, spruceKey);

			// Create temp directory
			if (Directory.Exists(tempDir))
				Directory.Delete(tempDir, true);

			foreach (string file in Directory.GetFiles(ProjectDir, "*.spruce.config", SearchOption.AllDirectories).Where(x => !x.Contains(@"\obj\")))
			{
				Log.LogWarning(file);
				var config = new SpruceConfig(file);
				var engine = new Engine(config, Path.GetDirectoryName(file), ProjectDir);
				engine.Minify = true;
				var output = engine.Render();

				string outputFile = relativePath(ProjectDir, file).Replace(".config", ".js");

				string completeOutputFile = Path.Combine(tempDir, outputFile);
				string completeOutputDirectory = Path.GetDirectoryName(completeOutputFile);

				Directory.CreateDirectory(completeOutputDirectory);

				File.WriteAllText(completeOutputFile, output.JavaScriptBody, Encoding.UTF8);
			}
			
			return true;
		}

		private string relativePath(string folderPath, string filePath)
		{
			var file = new Uri(filePath);

			// Must end in a slash to indicate folder
			var folder = new Uri(folderPath);

			return Uri.UnescapeDataString(
				folder.MakeRelativeUri(file)
					.ToString()
					.Replace('/', Path.DirectorySeparatorChar)
				);
		}
	}
}
