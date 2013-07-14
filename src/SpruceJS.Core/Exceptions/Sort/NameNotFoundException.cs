using System;

namespace SpruceJS.Core.Exceptions.Sort
{
	public class NameNotFoundException<T> : Exception
	{
		public string Name;
		public T Item;

		public NameNotFoundException(string name, T item)
		{
			Name = name;
			Item = item;
		}
	}
}
