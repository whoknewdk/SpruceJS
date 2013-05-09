using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpruceJS.Core
{
	public static class SortingService
	{
		// Topological sort
		public static IEnumerable<T> Sort<T>(IDictionary<string, T> Modules) where T : IEnumerable
		{
			// Topological sort
			foreach (var m in Modules.Values)
				//if (!m.Marked)
					foreach (T t in visit<T>(new SortItem<T>(m), Modules))
						yield return t;
		}

		static IEnumerable<T> visit<T>(SortItem<T> item, IDictionary<string, T> Modules) where T : IEnumerable
		{
			if (item.TempMarked)
				throw new Exception("Not DAG exception");

			if (!item.Marked)
			{
				item.TempMarked = true;

				foreach (string name in item.Item)
					foreach (T t in visit<T>(new SortItem<T>(Modules[name]), Modules))
						yield return t;

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
			this.Item = item;
		}
	}
}
