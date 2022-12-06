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
            char[][] grid = new char[5][]
            {
                new char[8] {'X','X','X','X','X','X','X','X'},
                new char[8] {'X','*','O','X','O','#','O','X'},
                new char[8] {'X','O','O','X','O','O','X','X'},
                new char[8] {'X','O','O','O','O','#','O','X'},
                new char[8] { 'X','X','X','X','X','X','X','X'}
            };

            var test = new GetFoodSln();
            var res = test.GetFood(grid);

            Console.WriteLine(res);
        }
    }
}
