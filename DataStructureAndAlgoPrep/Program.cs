using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new FileSystem();

            test.Mkdir("/a/b/c");

            test.AddContentToFile("/a/b/c/d", "Hello!");
        }
    }
}
