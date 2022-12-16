using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var test = new DailyTemperaturesSln();
            var res = test.DailyTemperatures(temperatures);
            Console.WriteLine(res);
        }
    }
}
