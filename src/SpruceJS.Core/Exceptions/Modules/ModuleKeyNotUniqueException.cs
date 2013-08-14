
namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleKeyNotUniqueException : SpruceException
	{
		public ModuleKeyNotUniqueException(string[] keys, string[] urls)
			: base(string.Format("Keys \"" + string.Join(",", keys) + "\" are not unique in files \"" + string.Join(",", urls) + "\""))
		{
			
		}
	}
}
