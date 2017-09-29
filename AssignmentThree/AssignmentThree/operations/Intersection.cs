using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.operations
{
    public class Intersection <T>
    {
        public HashSet<T> intersection(HashSet<T> list1, HashSet<T> list2)
		{
			HashSet<T> list = new HashSet<T>();

			foreach (T t in list1)
			{
				if (list2.Contains(t))
				{
					list.Add(t);
				}
			}

			return list;
		}

	}
}
