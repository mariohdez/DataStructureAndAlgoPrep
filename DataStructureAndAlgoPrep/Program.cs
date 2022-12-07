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

            var test = new MinKnightMovesSln();
            var res = test.MinKnightMoves(x: 5, y: 5);

            Console.WriteLine(res);
        }
    }
}
