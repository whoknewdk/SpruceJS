
namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleKeyDoesNotExistException : SpruceException
	{
		public ModuleKeyDoesNotExistException(string name, string url)
			: base("No module named \"" + name + "\" exists. Used in \"" + url + "\" exists")
		{
			
		}
	}
}
