using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new SortedSquaresSln();
            var nums = new int[] { -4, -1, 0, 3, 10 };

            var sln = test.SortedSquares(nums);

            System.Console.WriteLine(sln);
        }
    }
}
