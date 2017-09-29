using AssignmentThree.model;
using AssignmentThree.operations;
using AssignmentThree.subsets;
using System;

namespace AssignmentThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISetOperations<int> setOps = new SetOperations<int>();

            Console.WriteLine("Check if Memberships works");
            ICustomSet<int> A = new CustomSet<int>() { 1, 2, 3, 4 };
            ICustomSet<int> B = new CustomSet<int>() { 3, 4, 5, 6 };
            ICustomSet<int> resultSet = new CustomSet<int>();
            Console.WriteLine("Checks if 1 is a member of A. Should return true: \nReturn Value: " + setOps.Membership(1, A));
            Console.WriteLine("Checks if 5 is a member of A. Should return false: \nReturn Value: " + setOps.Membership(5, A));

            Console.WriteLine("\nChecks if Intersection works");
            Console.WriteLine("Intersecting set A with set B. Should return a set with the values 3 and 4");
            resultSet = setOps.Intersection(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Union works");
            Console.WriteLine("Create a union between set A with set B. Should return a set with the values 1, 2, 3, 4, 5 and 6");
            resultSet = setOps.Union(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Difference works");
            Console.WriteLine("Find the numbers that set A has but B doesn't. Should return a set with the values 1, 2");
            resultSet = setOps.Difference(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                if (i != 0) Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Compliment works");
            Console.WriteLine("Finds the compliment set used for a. Should return a set with the values 5 and 6");
            resultSet = setOps.Compliment(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                if (i != 0) Console.WriteLine("{0}", i);
            }
            
            Console.WriteLine("\nChecks if SubSets works");
            A = new CustomSet<int>() { 1, 2, 3, 4 };
            B = new CustomSet<int>() { 1, 2, 3, 4 };
            CustomSet<int> C = new CustomSet<int>() { 1, 2, 3 };
            CustomSet<int> D = new CustomSet<int>() { 4, 5, 6, 7 };

            Subset<int> compare = new Subset<int>();

            Console.WriteLine("Set a is the same as set b so it should return 0: RESULT " + setOps.IsSubSetOrEqual(A, B));
            Console.WriteLine("Set b is a subset of set a so it should return 1: RESULT " + setOps.IsSubSetOrEqual(A, C));
            Console.WriteLine("Set a is a subset of set b so it should return -1: RESULT " + setOps.IsSubSetOrEqual(C, A));
            Console.WriteLine("Set a and set b is completly different so it should return -2: RESULT " + setOps.IsSubSetOrEqual(A, D));

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}