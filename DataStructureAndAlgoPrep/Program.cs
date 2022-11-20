using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new InsertIntervalSln();
            // intervals = [[1,3],[6,9]], newInterval = [2,5]
            var intervals = new int[2][] {  new int[2] { 1,3 }, new int[2] { 6, 9 } };
            var newInterval = new int[2] { 2, 5 };
            var sln = test.Insert(intervals, newInterval);

            System.Console.WriteLine(sln);
        }
    }
}
