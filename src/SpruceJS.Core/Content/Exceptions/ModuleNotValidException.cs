using SpruceJS.Core.Exceptions;

namespace SpruceJS.Core.Content.Exceptions
{
	public class ModuleNotValidException : SpruceModuleException
	{
		public ModuleNotValidException(string path)
			: base("Module does not have valid structure \"" + path + "\"")
		{
			
		}
	}
}
