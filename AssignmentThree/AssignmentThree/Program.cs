using AssignmentThree.operations;
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

            Difference<int> diff = new Difference<int>();
            List<int> A = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> B = new List<int>() { 3, 4, 5, 6, 7, 8, 9 };
            HashSet<int> C = diff.difference(A, B);

            foreach (int i in C)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}