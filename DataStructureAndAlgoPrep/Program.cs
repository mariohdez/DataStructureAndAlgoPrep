using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9, 5, 4, 3, 2, 1
            // 1, 3, 5, 4, 3, 2, 1
            int[] nums = new int[] { 1, 2, 3 };

            var test = new NextPermutationSln();
            test.NextPermutation(nums: nums);
        }
    }
}
