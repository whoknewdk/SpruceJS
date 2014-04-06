﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using SpruceJS.Core.Combiner;
using SpruceJS.Core.Config;
using SpruceJS.Core.Config.Files;
using SpruceJS.Core.Content;
using SpruceJS.Core.Modules;
using SpruceJS.Core.Modules.Exceptions;
using SpruceJS.Core.Script;
using SpruceJS.Core.Sort.Exceptions;
using SpruceJS.Core.Visitor;

namespace SpruceJS.Core
{
	public class SpruceBuilder : IBuilder
	{
		private readonly ModuleItemList modules = new ModuleItemList();
		private readonly IList<ExternalItem> externals = new List<ExternalItem>();

		readonly Regex regex = new Regex(Regex.Escape("define("));
		readonly HashSet<string> keys = new HashSet<string>();

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

		public void LoadJS(string jsFilePath)
		{
			setModuleRootPath(jsFilePath);

			this.filePath = jsFilePath;
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

		public CombinerOutput GetOutput()
		{
			// Allow for mock
			if (loader == null)
				loader = new ContentLoader();

			if (fileConfig != null)
			{
				// Add externals
				foreach (var externalFile in fileConfig.Externals)
					externals.Add(createExternal(externalFile));

				var dependencies = new HashSet<string>();

				// Add files
				foreach (var file in fileConfig.Files)
				{
					var module = createModule(file, trimToName(urlPath(file)));
					modules.Add(module);

					// Is module actually null?
					if (module == null) 
						continue;

					// Store keys and dependencies
					keys.Add(module.Name);
					foreach (var d in module.Dependencies)
						dependencies.Add(d);
				}

				// Try to locate module on disk
				fetchModulesOnDisk(dependencies.Except(keys));
			}
			else
			{
				var module = createModule(filePath, trimToName(urlPath(filePath)));
				modules.Add(module);

				if (module != null)
					fetchModulesOnDisk(module.Dependencies);
			}

			try
			{
				var combiner = Minify ? new AjaxminCombiner() : new StandardCombiner();

				// Included js lib
				if (!ExcludeScript)
					combiner.Add(SpruceLib.Body, "spruce-define.js");

				// Add externals
				foreach (var external in externals)
					combiner.Add(external.Content, external.Url);

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

		private string trimToName(string name)
		{
			return name.Substring(1).Replace(".spruce.js", "").Replace(".js", "");
		}

		public string getFullPathForKey(string path)
		{
			return Path.Combine(ModuleRootPath, path);
		}

		private void fetchModulesOnDisk(IEnumerable<string> unfoundDependencies)
		{
			foreach (var unfoundDependency in unfoundDependencies)
			{
				var fileOnDisk = getFullPathForKey(unfoundDependency.Replace("/", "\\") + ".js");
				if (File.Exists(fileOnDisk))
				{
					var module = createModule(fileOnDisk, unfoundDependency);
					modules.Add(module);

					if (module == null)
						continue;

					// Add
					keys.Add(module.Name);
					fetchModulesOnDisk(module.Dependencies.Except(keys));
				}
			}
		}

		private ModuleItem createModule(string filePath, string name)
		{
			string content = loader.GetContent(filePath);
			
			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
			var moduleVisitor = new ModuleVisitor();

			moduleVisitor.Load(content);

			// Stop if content is not valid
			if (!moduleVisitor.IsValid)
				throw new ModuleNotValidException(filePath);

			string moduleId = moduleVisitor.Indentifier ?? name;
			string moduleContent = moduleVisitor.Indentifier != null
				                 ? content
								 : regex.Replace(content, String.Format("define('{0}',", moduleId), 1);
			string url = urlPath(filePath);

			// Build new module
			return new ModuleItem(url, moduleContent, moduleId, moduleVisitor.Dependencies.ToArray());
		}

		private ExternalItem createExternal(string filePath)
		{
			string content = loader.GetContent(filePath);

			// Stop if no file exists
			if (content == null)
				return null;

			string url = urlPath(filePath);

			// Build new module
			return new ExternalItem(url, content);
		}

		private string urlPath(string path)
		{
			if (!String.IsNullOrEmpty(ModuleRootPath))
				return "/" + path.Replace(ModuleRootPath, "").Replace("\\", "/");

			return path;
		}
	}
}
