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
            /*
"hot"
"dog"
["hot","dog"]
             */

            var test = new WordLadderSln();
            test.LadderLength("hot", "dog", new List<string> { "hot", "dog", });

            //var test = new MedianFinder();

            //test.AddNum(3);
            //test.AddNum(2);
            //test.AddNum(7);
            //test.AddNum(4);

            // System.Console.WriteLine(res);
        }
    }
}
