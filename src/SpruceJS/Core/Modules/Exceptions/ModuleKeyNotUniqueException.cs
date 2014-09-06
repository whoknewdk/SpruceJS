
namespace SpruceJS.Core.Modules.Exceptions
{
	public class ModuleKeyNotUniqueException : SpruceModuleException
	{
		public ModuleKeyNotUniqueException(string[] keys, string[] urls)
			: base(string.Format("Keys \"" + string.Join(",", keys) + "\" are not unique in files \"" + string.Join(",", urls) + "\""))
		{
			
		}
	}
}
