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
            int[][] heights = new int[5][]
            {
                new int[] { 1,2,2,3,5 },
                new int[] { 3,2,3,4,4 },
                new int[] { 2,4,5,3,1 },
                new int[] { 6,7,1,4,5 },
                new int[] { 5,1,1,2,4 },
            };

            var test = new PacificAtlanticSln();
            var res = test.PacificAtlantic(heights);

            Console.WriteLine(res);
        }
    }
}
