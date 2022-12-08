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
            // [["a"]]
            var board = new char[][] {
                new char[] { 'a' },
            };

            var words = new string[] { "a" };
            var test = new FindWordsSln();
            var res = test.FindWords(board, words);

            Console.WriteLine(res);
        }
    }
}
