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
            var test = new EncodeWordsSln();

            var res = test.encode(new List<string> { "Hello", "World" });
            test.decode("[1,0]");

            Console.WriteLine(res);
        }
    }
}
