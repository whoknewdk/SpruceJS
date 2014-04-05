
namespace SpruceJS.Core.Modules.Exceptions
{
	public class ModuleNotValidException : SpruceModuleException
	{
		public ModuleNotValidException(string path)
			: base("Module does not have valid structure \"" + path + "\"")
		{
			
		}
	}
}
