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
            var test = new TrapSln();

            int[] nums = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var res = test.Trap(nums);

            System.Console.WriteLine(res);
        }
    }
}
