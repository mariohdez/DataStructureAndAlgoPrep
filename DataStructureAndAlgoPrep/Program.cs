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
            var test = new WordSearchSln();
            var matrix = new char[3][]
            {
                new char[4]{ 'a', 'b', 'c', 'e' },
                new char[4]{ 's', 'f', 'c', 's' },
                new char[4]{ 'a', 'd', 'e', 'e' },
            };
            var res = test.Exist(matrix, "abcced");

            System.Console.WriteLine(res);
        }
    }
}
