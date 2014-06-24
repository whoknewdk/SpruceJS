using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using SpruceJS.Core;
using SpruceJS.Core.IO;

namespace SpruceJS.Build
{
	public class PublishSpruce : AppDomainIsolatedTask
	{
		public string ProjectDir { get; set; }

		[Output]
		public string OutputFiles { get; set; }

		private const string spruceTempRootDir = "SpruceTemp";

		public override bool Execute()
		{
			string tempDir = Path.Combine(ProjectDir, "obj", spruceTempRootDir);

			// Create temp directory
			if (Directory.Exists(tempDir))
				Directory.Delete(tempDir, true);

			foreach (string file in Directory.GetFiles(ProjectDir, "*.spruce.json", SearchOption.AllDirectories).Where(x => !x.Contains(@"\obj\")))
			{
				var engine = new SpruceBuilder(null, new FileSystem()) {
					Minify = true,
					ModuleRootPath = ProjectDir
				};
				engine.LoadConfig(file);

				var output = engine.GetOutput();

				string outputFile = PathUtil.GetPathDifference(ProjectDir, file).Replace(".json", ".js");

				string completeOutputFile = Path.Combine(tempDir, outputFile);
				string completeOutputDirectory = Path.GetDirectoryName(completeOutputFile);

				Directory.CreateDirectory(completeOutputDirectory);

				File.WriteAllText(completeOutputFile, output.JavaScriptBody, Encoding.UTF8);
			}

			// Expose destionation path
			OutputFiles = tempDir.Replace("\\", "/");
			
			return true;
		}
	}
}
