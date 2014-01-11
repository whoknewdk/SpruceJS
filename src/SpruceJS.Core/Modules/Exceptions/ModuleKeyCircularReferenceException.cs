
namespace SpruceJS.Core.Modules.Exceptions
{
	public class ModuleKeyCircularReferenceException : SpruceModuleException
	{
		public ModuleKeyCircularReferenceException(string[] url)
			: base("A circular reference exists for \"" + string.Join(",", url) + "\"")
		{
			
		}
	}
}
