using System;
using System.Collections.Generic;

namespace AssignmentThree.subsets
{
    class Subset<T>
    {
        public int isSubsetOrEqual(List<T> A, List<T> B)
        {
            if (Double.IsInfinity(A.Count) || Double.IsInfinity(B.Count)) return 2;
            bool equal = true;

            HashSet<T> largest = (A.Count <= B.Count) ? new HashSet<T>(B) : new HashSet<T>(A);
            List<T> smallest = (A.Count <= B.Count) ? A : B;

            for (int j = 0; j < smallest.Count; j++)
            {
                if (!largest.Contains(smallest[j]))
                {
                    equal = false;
                }
            }

            if (smallest.Count == largest.Count && equal) return 0;
            if (equal && smallest.Equals(A)) return -1;
            if (equal && smallest.Equals(B)) return 1;
            return -2;
        }
    }
}
