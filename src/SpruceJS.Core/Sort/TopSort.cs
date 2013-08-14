using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SpruceJS.Core.Exceptions.Sort;

namespace SpruceJS.Core.Sort
{
	public static class TopSort
	{
		// Topological sort
		public static IEnumerable<T> Sort<T>(IList<T> items, Func<T, string> getKey, Func<T, IEnumerable> getImports)
		{
			//var decoratedModules = Modules.ToDictionary(getKey, x => new SortItem<T>(x));
			var decoratedModules = items.Select(x => new SortItem<T>(x)).ToList();

			// Topological sort
			foreach (var item in decoratedModules)
			{
				if (!item.Marked)
					foreach (T t in visit(item, decoratedModules, getKey, getImports))
						yield return t;
			}
		}

		static IEnumerable<T> visit<T>(SortItem<T> item, IList<SortItem<T>> items, Func<T, string> getKey, Func<T, IEnumerable> getImports)
		{
			if (item.TempMarked)
			{
				var markedItems = items.Where(x => x.TempMarked).Select(x => x.Item).ToArray();
				throw new NotDirectedAcyclicGraphException<T>(markedItems);
			}

			if (!item.Marked)
			{
				item.TempMarked = true;

				foreach (string name in getImports(item.Item))
				{
					var mod = items.SingleOrDefault(x => getKey(x.Item) == name);

					if (mod == null)
						throw new NameNotFoundException<T>(name, item.Item);

					foreach (T t in visit(mod, items, getKey, getImports))
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
