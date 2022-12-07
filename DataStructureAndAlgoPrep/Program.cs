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
            int n = 6;
            int[][] edges = new int[6][]
            {
                new int[2] { 0, 5 },
                new int[2] { 0, 4 },
                new int[2] { 1, 0 },
                new int[2] { 2, 0 },
                new int[2] { 3, 1 },
                new int[2] { 2, 3 },
            };

            var test = new CourseScheduleIISln();
            var res = test.FindOrder(n, edges);

            Console.WriteLine(res);
        }
    }
}
