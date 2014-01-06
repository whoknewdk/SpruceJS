using System;

namespace SpruceJS.Core.Exceptions.Sort
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
