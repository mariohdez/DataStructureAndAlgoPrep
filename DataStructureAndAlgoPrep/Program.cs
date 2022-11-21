using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new EvalRevPolNotSln();
            
            var tokens = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            var sln = test.EvalRPN(tokens);

            System.Console.WriteLine(sln);
        }
    }
}
