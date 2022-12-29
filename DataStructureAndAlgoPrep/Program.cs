using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;
using DataStructureAndAlgoPrep.Week8;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            // [[[1,3],[6,7]],
            // [[2,4]],
            // [[2,5],[9,12]]]
            var str = "AABABBA";
            int k = 1;
            var test = new LongestRepeatingCharacterReplacementSln();
            var res = test.CharacterReplacement(str, k);
        }
    }
}
