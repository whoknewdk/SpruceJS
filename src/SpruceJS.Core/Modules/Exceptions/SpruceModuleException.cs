using System;

namespace SpruceJS.Core.Modules.Exceptions
{
	public class SpruceModuleException : Exception
	{
		public SpruceModuleException()
		{

		}

		public SpruceModuleException(string message)
			: base(message)
		{
			
		}
	}
}
