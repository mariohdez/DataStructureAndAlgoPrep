using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new OrangesRottingSln();
            var grid = new int[1][]
            {
                new int[2]{ 0,1 },
            };
            test.OrangesRotting(grid);
        }
    }
}
