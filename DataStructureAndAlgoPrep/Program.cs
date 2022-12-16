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
            string encodedString = "abc3[cd]xyz";

            var test = new DecodeStringSln();

            var result = test.DecodeString(encodedString);

            if (string.Equals(result, "abccdcdcdxyz"))
            {
                Console.WriteLine("correct");
            }
            else
            {
                throw new Exception("wrong got: " + result);
            }
        }
    }
}
