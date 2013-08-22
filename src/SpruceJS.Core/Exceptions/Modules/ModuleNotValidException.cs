
namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleNotValidException : SpruceException
	{
		public ModuleNotValidException(string path)
			: base("Module does not have valid structure \"" + path + "\"")
		{
			
		}
	}
}
