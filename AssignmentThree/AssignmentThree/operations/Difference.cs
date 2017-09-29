using System.Collections.Generic;

namespace AssignmentThree.operations
{
    class Difference<T>
    {
        public HashSet<T> difference(List<T> a, List<T> b)
        {
            HashSet<T> resultSet = new HashSet<T>();

            foreach (T t in a)
            {
                if (!b.Contains(t))
                {
                    resultSet.Add(t);
                }
            }
            return resultSet;
        }
    }
}
