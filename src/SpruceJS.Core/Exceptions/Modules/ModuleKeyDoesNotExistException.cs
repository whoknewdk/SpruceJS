using System;

namespace SpruceJS.Core.Exceptions.Modules
{
	public class ModuleKeyDoesNotExistException : Exception
	{
		public ModuleKeyDoesNotExistException(string name, string url)
			: base("No module with name (" + name + ", " + url + ") exists")
		{
			
		}
	}
}
