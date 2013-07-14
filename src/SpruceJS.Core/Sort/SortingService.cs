using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Exceptions.Sort;

namespace SpruceJS.Core.Sort
{
	public static class SortingService
	{
		// Topological sort
		public static IEnumerable<T> Sort<T>(IDictionary<string, T> Modules) where T : IEnumerable
		{
			var decoratedModules = Modules.ToDictionary(x => x.Key, x => new SortItem<T>(x.Value));

			// Topological sort
			foreach (var m in decoratedModules)
			{
				SortItem<T> item = m.Value;
				if (!item.Marked)
					foreach (T t in visit<T>(item, decoratedModules))
						yield return t;
			}
		}

		static IEnumerable<T> visit<T>(SortItem<T> item, IDictionary<string, SortItem<T>> Modules) where T : IEnumerable
		{
			if (item.TempMarked)
				throw new NotDirectedAcyclicGraphException();

			if (!item.Marked)
			{
				item.TempMarked = true;

				foreach (string name in item.Item)
				{
					if (!Modules.ContainsKey(name))
						throw new NameNotFoundException<T>(name, item.Item);

					foreach (T t in visit(Modules[name], Modules))
						yield return t;
				}

				item.TempMarked = false;
				item.Marked = true;

				yield return item.Item;
			}
		}
	}

	class SortItem<T>
	{
		public bool Marked = false;
		public bool TempMarked = false;
		public T Item;

		public SortItem(T item)
		{
			Item = item;
		}
	}
}
