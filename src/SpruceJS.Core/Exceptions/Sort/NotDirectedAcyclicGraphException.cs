using System;

namespace SpruceJS.Core.Exceptions.Sort
{
	public class NotDirectedAcyclicGraphException<T> : Exception
	{
		public T Item;

		public NotDirectedAcyclicGraphException(T item)
		{
			Item = item;
		}
	}
}
