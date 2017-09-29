using AssignmentThree.model;
using AssignmentThree.operations;
using AssignmentThree.subsets;
using System;
using System.Collections.Generic;

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
                // If Statement is due to default value of the customSet is 0, and the array holding the set is bigger so has a few 0 values.
                if (i != 0) Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Union works");
            Console.WriteLine("Create a union between set A with set B. Should return a set with the values 1, 2, 3, 4, 5 and 6");
            resultSet = setOps.Union(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                // If Statement is due to default value of the customSet is 0, and the array holding the set is bigger so has a few 0 values.
                if (i != 0) Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Difference works");
            Console.WriteLine("Find the numbers that set A has but B doesn't. Should return a set with the values 1, 2");
            resultSet = setOps.Difference(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                // If Statement is due to default value of the customSet is 0, and the array holding the set is bigger so has a few 0 values.
                if (i != 0) Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\nChecks if Compliment works");
            Console.WriteLine("Finds the compliment set used for a. Should return a set with the values 5 and 6");
            resultSet = setOps.Compliment(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                // If Statement is due to default value of the customSet is 0, and the array holding the set is bigger so has a few 0 values.
                if (i != 0) Console.WriteLine("{0}", i);
            }

            //List<int> A = new List<int>() { 1, 2, 3, 4 };
            //List<int> B = new List<int>() { 1, 2, 3, 4 };
            //List<int> C = new List<int>() { 1, 2, 3 };
            //List<int> D = new List<int>() { 4, 5, 6, 7 };

            //Subset<int> compare = new Subset<int>();

            //Console.WriteLine("Set a is the same as set b so it should return 0: RESULT " + compare.isSubsetOrEqual(A, B));
            //Console.WriteLine("Set b is a subset of set a so it should return -1: RESULT " + compare.isSubsetOrEqual(A, C));
            //Console.WriteLine("Set a is a subset of set b so it should return 1: RESULT " + compare.isSubsetOrEqual(C, A));
            //Console.WriteLine("Set a and set b is completly different so it should return -2: RESULT " + compare.isSubsetOrEqual(A, D));

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}