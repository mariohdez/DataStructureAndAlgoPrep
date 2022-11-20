using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new KClosestSln();
            
            var points = new int[2][] {  new int[2] { 1,3 }, new int[2] { -2, 2 } };
            var sln = test.KClosest(points,1);

            System.Console.WriteLine(sln);
        }
    }
}
