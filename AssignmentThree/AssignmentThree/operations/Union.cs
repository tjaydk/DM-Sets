using System;
using System.Collections.Generic;

namespace AssignmentThree.operations
{
    /// <summary>
    /// Take 2 sets, set a, and set b and make a union
    /// </summary>
    public class Union<T>
    {
        /// <summary>
        /// Takes two sets and creates a union between them.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public List<T> CreateUnion(List<T> a, List<T> b)
        {
            List<T> UnionizedSet = a;
            if (Double.IsInfinity(a.Count) || Double.IsInfinity(b.Count))
            {
                throw new NotImplementedException("Vos estas Loca");
            }

            HashSet<T> setA = new HashSet<T>(a);
            HashSet<T> setB = new HashSet<T>(b);
            
            foreach (T i in setB)
            {
                if (!setA.Contains(i))
                {
                    UnionizedSet.Add(i);
                }
            }

            return UnionizedSet;
        }
    }
}
