using SpruceJS.Core.Exceptions;

namespace SpruceJS.Core.Content.Exceptions
{
	public class ModuleKeyDoesNotExistException : SpruceModuleException
	{
		public ModuleKeyDoesNotExistException(string name, string url)
			: base("No module named \"" + name + "\" exists. Used in \"" + url + "\" exists")
		{
			
		}
	}
}
