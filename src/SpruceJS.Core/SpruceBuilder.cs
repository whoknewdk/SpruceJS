using System;
using System.IO;
using System.Linq;
using SpruceJS.Core.Combiner;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.IO;
using SpruceJS.Core.Modules;
using SpruceJS.Core.Modules.Exceptions;
using SpruceJS.Core.Script;
using SpruceJS.Core.Sort.Exceptions;

namespace SpruceJS.Core
{
	public class SpruceBuilder : IBuilder
	{
		private readonly ModuleItemList modules = new ModuleItemList();

		protected string filePath;
		protected IFileConfig fileConfig;
		protected IFileSystem fileSystem;

		public bool Minify { get; set; }
		public bool ExcludeScript { get; set; }

		public string ModuleRootPath { get; set; }

		public SpruceBuilder()
		{
			ModuleRootPath = "";
		}
		public SpruceBuilder(IFileConfig fileConfig, IFileSystem fileSystem)
		{
			ModuleRootPath = "";

			this.fileConfig = fileConfig;
			this.fileSystem = fileSystem;
		}

		public void LoadModule(string path)
		{
			setModuleRootPath(path);
			filePath = path;
		}

		// Single file entry constructor
		public void LoadConfig(string path)
		{
			setModuleRootPath(path);

			string content = fileSystem.ReadAllText(Path.GetFullPath(path));
			var config = new SpruceConfig();
			config.LoadJson(content);

			// Allow for mock
			if (fileConfig == null)
				fileConfig = new FileConfig(config, ModuleRootPath, path);

			ExcludeScript = !config.IncludeScript;
		}

		private void setModuleRootPath(string file)
		{
			if (String.IsNullOrEmpty(ModuleRootPath))
				ModuleRootPath = Path.GetDirectoryName(file);
		}

		private void addModules(string filepath, ItemFactory itemFactory, ModuleResolver moduleResolver)
		{
			var module = itemFactory.CreateModule(filepath);

			// Try to locate referenced modules on disk
			if (module != null)
				modules.AddRange(moduleResolver.fetchModulesOnDisk(module));
		}

		public CombinerOutput GetOutput()
		{
			// Allow for mock
			if (fileSystem == null)
				fileSystem = new FileSystem();

			var itemFactory = new ItemFactory(ModuleRootPath, fileSystem);
			var moduleResolver = new ModuleResolver(ModuleRootPath, itemFactory);

			// Decided combiner strategy
			var combiner = Minify ? new AjaxminCombiner() : new StandardCombiner();

			// Included js lib
			if (!ExcludeScript)
				combiner.Add(SpruceLib.Body, "spruce-define.js");

			try
			{
				if (fileConfig != null)
				{
					// Add externals
					foreach (var externalFile in fileConfig.Externals)
					{
						var external = itemFactory.CreateExternal(externalFile);
						combiner.Add(external.Content, external.Url);
					}

					// Add files
					foreach (var filepath in fileConfig.Files)
						addModules(filepath, itemFactory, moduleResolver);
				}
				else
				{
					addModules(filePath, itemFactory, moduleResolver);
				}

				// Add modules
				foreach (var module in modules)
					combiner.Add(module.Content, module.Url);

				return combiner.GetOutput();
			}
			catch (NameNotFoundException<ModuleItem> ex)
			{
				throw new ModuleKeyDoesNotExistException(ex.Name, ex.Item.Url);
			}
			catch (NotDirectedAcyclicGraphException<ModuleItem> ex)
			{
				throw new ModuleKeyCircularReferenceException(ex.Items.Select(x => x.Url).ToArray());
			}
		}
	}
}
