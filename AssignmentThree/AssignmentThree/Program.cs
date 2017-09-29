﻿using AssignmentThree.operations;
using System;
using System.Collections.Generic;

namespace AssignmentThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Union<int> union = new Union<int>();

            List<int> a = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> b = new List<int>() { 2, 3, 4, 5, 6, 7 };

            List<int> c = union.CreateUnion(a, b);

            foreach (int i in c)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}