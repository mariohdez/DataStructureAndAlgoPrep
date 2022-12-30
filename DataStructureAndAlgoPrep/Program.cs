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
            int[] nums = new int[] {-1, 2, 1, -4};
            int target = 1;

            var test = new ThreeSumClosestSln();
            var res = test.ThreeSumClosest(nums, target);
        }
    }
}
