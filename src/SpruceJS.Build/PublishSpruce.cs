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
		public string SearchPattern { get; set; }

		[Output]
		public string OutputFiles { get; set; }

		private const string spruceTempRootDir = "SpruceTemp";

		public override bool Execute()
		{
			string tempDir = Path.Combine(ProjectDir, "obj", spruceTempRootDir);

			// Create temp directory
			if (Directory.Exists(tempDir))
				Directory.Delete(tempDir, true);

			foreach (var pattern in SearchPattern.Split(';'))
			{
				var files = Directory.GetFiles(ProjectDir, pattern, SearchOption.AllDirectories).Where(path => !path.Contains(@"\obj\"));
				foreach (string file in files)
				{
					var engine = new SpruceBuilder(null, new FileSystem())
					{
						Minify = true,
						ModuleRootPath = ProjectDir
					};

					var content = File.ReadAllText(file);
					if (content.Contains("define("))
						engine.LoadModule(file);
					else
						engine.LoadConfig(file);

					var output = engine.GetOutput();

					// Make extension .spruce.js
					string outputFile = PathUtil.GetPathDifference(ProjectDir, file).Replace(".js", ".spruce.js");
					outputFile = outputFile.Replace(".spruce.json", ".spruce.js");

					// We need absolute paths
					string absoluteOutputFile = Path.Combine(tempDir, outputFile);
					string absoluteOutputDirectory = Path.GetDirectoryName(absoluteOutputFile);

					// Create output directory
					Directory.CreateDirectory(absoluteOutputDirectory);

					// Write file to disk
					File.WriteAllText(absoluteOutputFile, output.JavaScriptBody, Encoding.UTF8);
				}
				
			}

			// Expose destionation path
			OutputFiles = tempDir.Replace("\\", "/");
			
			return true;
		}
	}
}
