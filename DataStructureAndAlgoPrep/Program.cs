using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ThreeSumSln();
            
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var sln = test.ThreeSum(nums);

            System.Console.WriteLine(sln);
        }
    }
}
