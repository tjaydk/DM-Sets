﻿using AssignmentThree.model;
using AssignmentThree.operations;
using System;

namespace AssignmentThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISetOperations<int> setOps = new SetOperations<int>();

            Console.WriteLine("A: {1, 2, 3, 4}");
            Console.WriteLine("B: {3, 4, 5, 6}\n");

            Console.WriteLine("\nCheck if Memberships works".ToUpper());
            ICustomSet<int> A = new CustomSet<int>() { 1, 2, 3, 4 };
            ICustomSet<int> B = new CustomSet<int>() { 3, 4, 5, 6 };
            ICustomSet<int> resultSet = new CustomSet<int>();
            Console.WriteLine("Checks if 1 is a member of A. Should return true: \nReturn Value: " + setOps.Membership(1, A));
            Console.WriteLine("Checks if 5 is a member of A. Should return false: \nReturn Value: " + setOps.Membership(5, A));

            Console.WriteLine("\n\nChecks if Intersection works".ToUpper());
            Console.WriteLine("Intersecting set A with set B. Should return a set with the values 3 and 4");
            resultSet = setOps.Intersection(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                Console.Write("{0},", i);
            }

            A = new CustomSet<int>() { 1, 2, 3, 4 };
            B = new CustomSet<int>() { 3, 4, 5, 6 };
            Console.WriteLine("\n\nChecks if Union works".ToUpper());
            Console.WriteLine("Create a union between set A with set B. Should return a set with the values 1, 2, 3, 4, 5 and 6");
            resultSet = setOps.Union(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                Console.Write("{0},", i);
            }

            A = new CustomSet<int>() { 1, 2, 3, 4 };
            B = new CustomSet<int>() { 3, 4, 5, 6 };
            Console.WriteLine("\n\nChecks if Difference works".ToUpper());
            Console.WriteLine("Find the numbers that set A has but B doesn't. Should return a set with the values 1, 2");
            resultSet = setOps.Difference(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                if (i != 0) Console.Write("{0},", i);
            }

            A = new CustomSet<int>() { 1, 2, 3, 4 };
            B = new CustomSet<int>() { 3, 4, 5, 6 };
            Console.WriteLine("\n\nChecks if Compliment works".ToUpper());
            Console.WriteLine("Finds the compliment set used for a. Should return a set with the values 5 and 6");
            resultSet = setOps.Compliment(A, B);
            Console.WriteLine("Printing results: ");
            foreach (int i in resultSet)
            {
                if (i != 0) Console.Write("{0},", i);
            }


            Console.WriteLine("\n\nA: {1, 2, 3, 4}");
            Console.WriteLine("B: {1, 2, 3, 4}");
            Console.WriteLine("C: {1, 2, 3}");
            Console.WriteLine("D: {4, 5, 6, 7}\n");

            Console.WriteLine("\nChecks if SubSets works".ToUpper());
            A = new CustomSet<int>() { 1, 2, 3, 4 };
            B = new CustomSet<int>() { 1, 2, 3, 4 };
            CustomSet<int> C = new CustomSet<int>() { 1, 2, 3 };
            CustomSet<int> D = new CustomSet<int>() { 4, 5, 6, 7 };

            Console.WriteLine("Set a is the same as set b so it should return 0: RESULT " + setOps.IsSubSetOrEqual(A, B));
            Console.WriteLine("Set b is a subset of set a so it should return 1: RESULT " + setOps.IsSubSetOrEqual(A, C));
            Console.WriteLine("Set a is a subset of set b so it should return -1: RESULT " + setOps.IsSubSetOrEqual(C, A));
            Console.WriteLine("Set a and set b is completly different so it should return -2: RESULT " + setOps.IsSubSetOrEqual(A, D));

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}