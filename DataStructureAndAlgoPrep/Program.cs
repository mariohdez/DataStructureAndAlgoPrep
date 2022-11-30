using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MinimumOperationsSln();

            int[] nums = new int[] { 0 };

            var res = test.MinimumOperations(nums);

            System.Console.WriteLine(res);
        }
    }
}
