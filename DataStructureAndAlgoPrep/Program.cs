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
            var test = new TaskSchedulerSln();
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', };

            var res = test.LeastInterval(tasks, 2);

            System.Console.WriteLine(res);
        }
    }
}
