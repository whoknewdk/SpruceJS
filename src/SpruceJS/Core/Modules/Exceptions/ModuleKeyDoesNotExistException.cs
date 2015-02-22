
namespace SpruceJS.Core.Modules.Exceptions
{
	public class ModuleKeyDoesNotExistException : SpruceModuleException
	{
		public ModuleKeyDoesNotExistException(string name, string url)
			: base("No module named \"" + name + "\" exists. Used in \"" + url + "\".")
		{
			
		}
	}
}
