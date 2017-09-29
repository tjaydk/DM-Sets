using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.operations
{
    /// <summary>
    /// This class returns a compliment set containing all the members of the subset B in
    /// Ac(A compliment) B.
    /// </summary>
    public class Compliment<T>
    {
        /// <summary>
        /// Takes two sets of type T where set B is the compliment set used for set A.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public List<T> FindCompliment(List<T> A, List<T> B)
        {
            if (Double.IsInfinity(B.Count)){
                throw new FormatException("List is infinite");
            } else {
                foreach (T item in A)
                {
                    if (B.Contains(item)) B.Remove(item);
                }
                return B;
            }
        }
    }
}
