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
            var test = new SetZeroesSln();

            int[][] matrix = new int[3][]
            {
                new int[] { -4,-2147483648,6,-7,0 },
                new int[] { -8,6,-8,-6,0 },
                new int[] { 2147483647,2,-9,-6,-10 },
            };

            var res = 0;

            test.SetZeroes(matrix);

            Console.WriteLine(res);
        }
    }
}
