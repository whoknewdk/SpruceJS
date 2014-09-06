using System;

namespace SpruceJS.Core.Sort.Exceptions
{
	internal class NotDirectedAcyclicGraphException<T> : Exception
	{
		public T[] Items;

		internal NotDirectedAcyclicGraphException(T[] items)
		{
			Items = items;
		}
	}
}
