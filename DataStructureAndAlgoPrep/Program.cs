using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;
using DataStructureAndAlgoPrep.Week8;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {3, 4},
                new int[] {1, 3},
            };
            var test = new EraseOverlapIntervalSln();
            var res = test.EraseOverlapIntervals(intervals);
        }
    }
}
