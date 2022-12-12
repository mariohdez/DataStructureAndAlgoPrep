using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             nums = [1,2,3], k = 3
             
             */
            int[] nums = new int[] { 1, 2, 3 };
            int k = 3;


            var test = new SubarraySumSln();
            var res = test.SubarraySum(nums, k: k);

            Console.WriteLine(res);
        }
    }
}
