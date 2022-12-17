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
            string str = ")()())((()))";

            var test = new LongestValidParenthesesSln();

            var result = test.LongestValidParentheses(str);
        }
    }
}
