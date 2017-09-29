using AssignmentThree.model;

namespace AssignmentThree.operations
{
    public interface ISetOperations<T>
    {
        ICustomSet<T> Membership(T t, ICustomSet<T> A);
        ICustomSet<T> Intersection(ICustomSet<T> A, ICustomSet<T> B);
        ICustomSet<T> Union(ICustomSet<T> A, ICustomSet<T> B);
        ICustomSet<T> Difference(ICustomSet<T> A, ICustomSet<T> B);
        ICustomSet<T> Compliment(ICustomSet<T> A, ICustomSet<T> B);
    }
}
