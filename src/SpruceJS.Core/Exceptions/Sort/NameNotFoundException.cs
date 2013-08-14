
namespace SpruceJS.Core.Exceptions.Sort
{
	public class NameNotFoundException<T> : SpruceException
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
