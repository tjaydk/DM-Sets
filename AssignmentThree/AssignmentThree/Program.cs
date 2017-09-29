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
            //Compliment<int> c = new Compliment<int>();
            //List<int> A = new List<int>() { 1, 2, 3, 4 };
            //List<int> B = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> C = c.FindCompliment(A, B);

            //Intersection<int> test = new Intersection<int>();
            //HashSet<int> A = new HashSet<int>() { 2,3,4,5,6};
            //HashSet<int> B = new HashSet<int>() { 2,3,4,7,8};
            //HashSet<int> C = test.intersection(A, B);

            // Union<int> union = new Union<int>();
            // List<int> A = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // List<int> B = new List<int>() { 2, 3, 4, 5, 6, 7 };
            // List<int> C = union.CreateUnion(A, B);

            //Difference<int> diff = new Difference<int>();
            //List<int> A = new List<int>() { 1, 2, 3, 4, 5 };
            //List<int> B = new List<int>() { 3, 4, 5, 6, 7, 8, 9 };
            //HashSet<int> C = diff.difference(A, B);

            //foreach (int i in C)
            //{
            //    Console.WriteLine("{0}", i);
            //}

            //List<int> A = new List<int>() { 1, 2, 3, 4 };
            //List<int> B = new List<int>() { 1, 2, 3, 4 };
            //List<int> C = new List<int>() { 1, 2, 3 };
            //List<int> D = new List<int>() { 4, 5, 6, 7 };

            //Subset<int> compare = new Subset<int>();

            //Console.WriteLine("Set a is the same as set b so it should return 0: RESULT " + compare.isSubsetOrEqual(A, B));
            //Console.WriteLine("Set b is a subset of set a so it should return -1: RESULT " + compare.isSubsetOrEqual(A, C));
            //Console.WriteLine("Set a is a subset of set b so it should return 1: RESULT " + compare.isSubsetOrEqual(C, A));
            //Console.WriteLine("Set a and set b is completly different so it should return -2: RESULT " + compare.isSubsetOrEqual(A, D));

            ICustomSet<int> set = new CustomSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8 };

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}