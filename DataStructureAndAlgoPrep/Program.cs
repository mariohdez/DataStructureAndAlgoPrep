using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;
using DataStructureAndAlgoPrep.Week8;
using DataStructureAndAlgoPrep.Week9;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] routes = new int[][] {
                new int[] { 1, 2, 7 },
                new int[] { 3, 6, 7 },
            };

            var test = new NumBusesToDestinationSln();
            var res = test.NumBusesToDestination(routes, source: 6, target: 7);
        }
    }
}
