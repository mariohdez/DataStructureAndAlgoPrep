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
            var test = new CalculateSln();
            //var s = new Stack<string>();
            //s.Push(")");
            //s.Push("99");
            //s.Push("+");
            //s.Push("82");
            //s.Push("-");
            //s.Push("70");
            //test.EvaluateStack(s);
            test.Calculate("(7-44)+(70-82+99)");
        }
    }
}
