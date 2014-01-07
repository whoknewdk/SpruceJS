using SpruceJS.Core.Exceptions;

namespace SpruceJS.Core.Content.Exceptions
{
	public class ModuleKeyCircularReferenceException : SpruceModuleException
	{
		public ModuleKeyCircularReferenceException(string[] url)
			: base("A circular reference exists for \"" + string.Join(",", url) + "\"")
		{
			
		}
	}
}
