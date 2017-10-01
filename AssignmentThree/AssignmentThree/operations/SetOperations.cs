using AssignmentThree.model;
using System;

namespace AssignmentThree.operations
{
    class SetOperations<T> : ISetOperations<T>
    {
        /// <summary>
        /// Returns if t is a member of set A.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public bool Membership(T t, ICustomSet<T> A)
        {
            if (A.IsInfinite())
            {
                throw new FormatException("List is infinite");
            }

            return A.Contains(t);
        }

        /// <summary>
        /// Takes two sets of type T and returns the intersection of the two sets.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Intersection(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (A.IsInfinite() || B.IsInfinite())
            {
                throw new FormatException("List is infinite");
            }

            foreach (T t in A)
            { 
                if (!B.Contains(t))
                {
                    A.Delete(t);
                }
            }

            return A;
        }

        /// <summary>
        /// Takes two sets of type T and returns the union of the two sets.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Union(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (A.IsInfinite() || B.IsInfinite())
            {
                throw new FormatException("List is infinite");
            }

            foreach (T t in B)
            {
                if (!A.Contains(t))
                {
                    A.Add(t);
                }
            }
            
            return A;
        }

        /// <summary>
        /// Takes two sets of type T and returns the difference between the sets.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Difference(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (A.IsInfinite() || B.IsInfinite())
            {
                throw new FormatException("List is infinite");
            }

            foreach (T t in B)
            {
                if (A.Contains(t))
                {
                    A.Delete(t);
                }
            }
            return A;
        }

        /// <summary>
        /// Takes two sets of type T where set B is the compliment set used for set A.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Compliment(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (A.IsInfinite() || B.IsInfinite())
            {
                throw new FormatException("List is infinite");
            }

            foreach (T t in A)
            {
                if (B.Contains(t))
                {
                    B.Delete(t);
                }
            }
            return B;
        }

        /// <summary>
        /// returns 0 if two sets are equal.
        /// returns 1 if A is a subset of B.
        /// returns -1 if B is a subset of A.
        /// returns -2 if the sets are completly different.
        /// returns 2 if either of the sets are infinite.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int IsSubSetOrEqual(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (A.IsInfinite() || B.IsInfinite()) return 2;
            bool equal = true;

            ICustomSet<T> largest = (A.Size() <= B.Size()) ? B : A;
            ICustomSet<T> smallest = (A.Size() <= B.Size()) ? A : B;

            foreach (T t in smallest)
            {
                if (!largest.Contains(t))
                {
                    equal = false;
                }
            }

            if (smallest.Size() == largest.Size() && equal) return 0;
            if (equal && smallest.Equals(A)) return -1;
            if (equal && smallest.Equals(B)) return 1;
            return -2;
        }
    }
}
