
namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleKeyDoesNotExistException : SpruceException
	{
		public ModuleKeyDoesNotExistException(string name, string url)
			: base("No module named \"" + name + "\" used in \"" + url + "\" exists")
		{
			
		}
	}
}
