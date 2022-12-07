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
            int n = 1;
            int[][] edges = new int[][]{};

            var test = new GraphValidTreeSln();
            var res = test.ValidTree(n, edges);

            Console.WriteLine(res);
        }
    }
}
