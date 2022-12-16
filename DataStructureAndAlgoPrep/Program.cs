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
            var freqStack = new FreqStack();
            var input = "[4],[0],[9],[3],[4],[2],[],[6],[],[1],[],[1],[],[4],[],[],[],[],[],[]";

            var elements = input.Split(",");


            foreach (var command in elements)
            {
                if (string.Equals(command, "[]"))
                {
                    freqStack.Pop();
                }
                else
                {
                    var test = String.Join("", command.Split('[', ']'));
                    Console.WriteLine(test);
                    if (int.TryParse(test, out var num))
                    {
                        freqStack.Push(num);
                    }
                }
            }

        }
    }
}
