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
            int[] nums = new int[] {3,1,2};

            var test = new FindMinSln();
            var res = test.FindMin(nums);
        }
    }
}
