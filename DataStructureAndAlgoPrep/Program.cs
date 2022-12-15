using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[] { 6, 7, 5, 2, 4, 5, 8, 3 };

            var test = new LargestRectangleAreaSln();

            var res = test.LargestRectangleArea(heights: heights);
            Console.WriteLine(res);
        }
    }
}
