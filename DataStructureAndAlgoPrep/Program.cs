using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[][] edges = new int[3][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 2 },
                new int[2] { 3, 4 },
            };

            var test = new CountComponentsSln();
            var res = test.CountComponents(n, edges);

            Console.WriteLine(res);
        }
    }
}
