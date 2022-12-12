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
            int n = 3;

            var test = new GenerateParenthesisSln();
            test.GenerateParenthesis(n: n);
        }
    }
}
