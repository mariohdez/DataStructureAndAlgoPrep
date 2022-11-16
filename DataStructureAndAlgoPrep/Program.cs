using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new RomanToIntSln();

            var sln = test.RomanToInt("MCMXCIV");

            if (sln != 1994)
            {
                throw new Exception("blah");
            }

            System.Console.WriteLine(sln);
        }
    }
}
