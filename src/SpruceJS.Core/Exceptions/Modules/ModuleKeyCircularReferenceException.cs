
namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleKeyCircularReferenceException : SpruceException
	{
		public ModuleKeyCircularReferenceException(string url)
			: base("A circular reference exists for \"" + url + "\"")
		{
			
		}
	}
}
