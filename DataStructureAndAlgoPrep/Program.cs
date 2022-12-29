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

            int[] nums = new int[] { 3, 30, 34, 5, 9 };
            var test = new LargestNumberSln();
            var res = test.LargestNumber(nums);
        }
    }
}
