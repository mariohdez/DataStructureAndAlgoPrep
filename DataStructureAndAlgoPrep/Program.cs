﻿using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MergeSln();
            var intervals = new int[4][]
            {
                new int[2]{ 1,3 },
                new int[2]{ 2,6 },
                new int[2]{ 8,10 },
                new int[2]{ 15,18 },
            };
            test.Merge(intervals);
        }
    }
}
