using System.Collections.Generic;

namespace AssignmentThree.model
{
    public interface ICustomSet<T> : IEnumerable<T>
    {
        void Add(T key);
        void Delete(T key);
        bool Contains(T key);
        int Size();
        bool IsInfinite();
    }
}
