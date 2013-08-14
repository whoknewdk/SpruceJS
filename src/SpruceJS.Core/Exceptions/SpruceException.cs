
using System;

namespace SpruceJS.Core.Exceptions
{
	public class SpruceException : Exception
	{
		public SpruceException()
		{

		}

		public SpruceException(string message)
			: base(message)
		{
			
		}
	}
}
