using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<IList<int>>()
            {
                new List<int> { -5,-4,-3,-2,-1,1 },
                new List<int> { 1,2,3,4,5, },
            };

            var test = new SmallestRangeSln();

            var result = test.SmallestRange(nums);
        }
    }
}
