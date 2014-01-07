using System;

namespace SpruceJS.Core.Sort.Exceptions
{
	internal class NameNotFoundException<T> : Exception
	{
		public string Name;
		public T Item;

		internal NameNotFoundException(string name, T item)
		{
			Name = name;
			Item = item;
		}
	}
}
