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
            var test = new WordDictionary();

            test.AddWord("at");
            test.AddWord("and");
            test.AddWord("an");
            test.AddWord("add");
            
            var res = test.Search(".at");
        }
        /*
        
        ["search","search","addWord","search","search","search","search","search","search"]
        [["a"],[".at"],["bat"],[".at"],["an."],["a.d."],["b."],["a.d"],["."]]
*/
    }
}
