using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new LetterCombinationsForPhoneNumbersSln();
            // var nums = new int[] { 1,2,3 };
            var res = test.LetterCombinations("23");

            System.Console.WriteLine(res);
        }
    }
}
