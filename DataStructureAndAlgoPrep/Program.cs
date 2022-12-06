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
            int[][] matrix = new int[3][]
            {
                new int[4]{ 1,   3,  5,  7 },
                new int[4]{ 10, 11, 16, 20 },
                new int[4]{ 23, 30, 34, 60 },
            };

            var test = new SearchMatrixSln();
            var res = test.SearchMatrix(matrix, 34);

            Console.WriteLine(res);
        }
    }
}
