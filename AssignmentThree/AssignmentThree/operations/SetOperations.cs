using AssignmentThree.model;
using System;
using System.Collections.Generic;

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
            if (Double.IsInfinity(A.Size()))
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
            if (Double.IsInfinity(A.Size()) || Double.IsInfinity(B.Size()))
            {
                throw new FormatException("List is infinite");
            }

            CustomSet<T> resultSet = new CustomSet<T>();

            foreach (T t in A)
            {
                if (B.Contains(t))
                {
                    resultSet.Add(t);
                }
            }

            return resultSet;
        }

        /// <summary>
        /// Takes two sets of type T and returns the union of the two sets.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Union(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (Double.IsInfinity(A.Size()) || Double.IsInfinity(B.Size()))
            {
                throw new FormatException("List is infinite");
            }

            ICustomSet<T> resultSet = A;

            foreach (T i in B)
            {
                if (!A.Contains(i))
                {
                    resultSet.Add(i);
                }
            }

            return resultSet;
        }

        /// <summary>
        /// Takes two sets of type T and returns the difference between the sets.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Difference(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (Double.IsInfinity(A.Size()) || Double.IsInfinity(B.Size()))
            {
                throw new FormatException("List is infinite");
            }

            CustomSet<T> resultSet = new CustomSet<T>();

            foreach (T t in A)
            {
                if (!B.Contains(t))
                {
                    resultSet.Add(t);
                }
            }
            return resultSet;
        }

        /// <summary>
        /// Takes two sets of type T where set B is the compliment set used for set A.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public ICustomSet<T> Compliment(ICustomSet<T> A, ICustomSet<T> B)
        {
            if (Double.IsInfinity(A.Size()) || Double.IsInfinity(B.Size()))
            {
                throw new FormatException("List is infinite");
            }

            foreach (T t in A)
            {
                if (B.Contains(t)) B.Delete(t);
            }
            return B;
        }
    }
}
