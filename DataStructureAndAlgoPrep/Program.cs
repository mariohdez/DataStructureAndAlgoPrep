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

            int[] nums = new int[] { 1 };
            int k = 1;
            var test = new MaxSlidingWindowSln();
            var res = test.MaxSlidingWindow(nums, k);
        }
    }
}
