using System;
using System.IO;
using System.Linq;
using SpruceJS.Core.Combiner;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
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
		protected IContentLoader loader;

		public bool Minify { get; set; }
		public bool ExcludeScript { get; set; }

		public string ModuleRootPath { get; set; }

		public SpruceBuilder()
		{
			ModuleRootPath = "";
		}
		public SpruceBuilder(IFileConfig fileConfig, IContentLoader loader)
		{
			ModuleRootPath = "";

			this.fileConfig = fileConfig;
			this.loader = loader;
		}

		public void LoadJS(string filePath)
		{
			setModuleRootPath(filePath);

			this.filePath = filePath;
		}

		// Single file entry constructor
		public void LoadConfig(string configFilePath)
		{
			setModuleRootPath(configFilePath);

			var config = new SpruceConfig();
			config.Load(configFilePath);

			// Allow for mock
			if (fileConfig == null)
				fileConfig = new FileConfig(config, ModuleRootPath, configFilePath);

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
			if (module != null)
			{
				// Try to locate referenced modules on disk
				modules.AddRange(moduleResolver.fetchModulesOnDisk(module));
			}
		}

		public CombinerOutput GetOutput()
		{
			// Allow for mock
			if (loader == null)
				loader = new ContentLoader();

			var itemFactory = new ItemFactory(ModuleRootPath, loader);
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
