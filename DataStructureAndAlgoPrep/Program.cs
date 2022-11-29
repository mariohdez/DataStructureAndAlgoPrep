using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new SpiralOrderSln();
            var matrix = new int[3][]
            {
                new int[3]{ 1, 2, 3 },
                new int[3]{ 4, 5, 6 },
                new int[3]{ 7, 8, 9 },
            };
            var res = test.SpiralOrder(matrix);

            System.Console.WriteLine(res);
        }
    }
}



/**
 * 
[["John","johnsmith@mail.com","john_newyork@mail.com"],["John","johnsmith@mail.com","john00@mail.com"],["Mary","mary@mail.com"],["John","johnnybravo@mail.com"]]
 * 
 */
