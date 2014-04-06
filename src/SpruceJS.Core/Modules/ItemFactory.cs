using System;
using System.Linq;
using System.Text.RegularExpressions;
using SpruceJS.Core.Content;
using SpruceJS.Core.Modules.Exceptions;
using SpruceJS.Core.Visitor;

namespace SpruceJS.Core.Modules
{
	public class ItemFactory
	{
		readonly Regex regex = new Regex(Regex.Escape("define("));

		readonly string moduleRootPath;
		readonly IContentLoader loader;
		public ItemFactory(string moduleRootPath, IContentLoader loader)
		{
			this.moduleRootPath = moduleRootPath;
			this.loader = loader;
		}

		public ModuleItem CreateModule(string filename)
		{
			return CreateModule(filename, trimToName(urlPath(filename)));
		}

		public ModuleItem CreateModule(string filename, string name)
		{
			string content = loader.GetContent(filename);

			// Stop if no file exists
			if (content == null)
				return null;

			// Read/Analyse file
			var moduleVisitor = new ModuleVisitor();
			moduleVisitor.Load(content);

			// Stop if content is not valid
			if (!moduleVisitor.IsValid)
				throw new ModuleNotValidException(filename);

			string moduleId = moduleVisitor.Indentifier ?? name;
			string moduleContent = moduleVisitor.Indentifier != null
								 ? content
								 : regex.Replace(content, String.Format("define('{0}',", moduleId), 1);

			string url = urlPath(filename);

			// Build new module
			return new ModuleItem(url, moduleContent, moduleId, moduleVisitor.Dependencies.ToArray());
		}

		public ExternalItem CreateExternal(string filename)
		{
			string content = loader.GetContent(filename);

			// Stop if no file exists
			if (content == null)
				return null;

			string url = urlPath(filename);

			// Build new module
			return new ExternalItem(url, content);
		}

		private string trimToName(string name)
		{
			return name.Substring(1).Replace(".spruce.js", "").Replace(".js", "");
		}

		private string urlPath(string path)
		{
			if (!String.IsNullOrEmpty(moduleRootPath))
				return "/" + path.Replace(moduleRootPath, "").Replace("\\", "/");

			return path;
		}
	}
}
