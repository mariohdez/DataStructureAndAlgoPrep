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
            var board = new char[][] {
                new char[] { 'a' },
            };

            /*
             * 
             * 
             
             * 
             * int n, int[][] flights, int src, int dst, int k
             n = 3, flights = [[],[],[]], src = 0, dst = 2, k = 1

             */

            var test = new FindCheapestPriceSln();
            var res = test.FindCheapestPrice(
                n: 3,
                flights: new int[][]
                {
                    new int[] { 0,1,100 },
                    new int[] { 1,2,100 },
                    new int[] { 0,2,500 },
                },
                src: 0,
                dst: 2,
                k: 1);


            Console.WriteLine(res);
        }
    }
}
