using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 };
            int bricks = 10;
            int ladders = 2;
            var test = new FurthestBuildingSln();
            test.FurthestBuilding(heights, bricks: bricks, ladders: ladders);
        }
    }
}
