using System;

namespace SpruceJS.Core.Exceptions.Sort
{
	public class NotDirectedAcyclicGraphException<T> : Exception
	{
		public T[] Items;

		public NotDirectedAcyclicGraphException(T[] items)
		{
			Items = items;
		}
	}
}
