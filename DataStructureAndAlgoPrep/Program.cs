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
            var test = new RotateSln();
            int[] hi = new int[] { -1, -100, 3, 99 };
            int k = 2;

            test.Rotate(hi, k);

            Console.WriteLine(hi);
        }
    }
}
