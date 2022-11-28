using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new AccountsMergeSln();
            List<IList<string>> accounts = new List<IList<string>>
            {
                new List<string>
                {
                    "John","johnsmith@mail.com","john_newyork@mail.com",
                },
                new List<string>
                {
                    "Mary","mary@mail.com",
                },
                new List<string>
                {
                    "John","johnnybravo@mail.com",
                },
            };
            var res = test.AccountsMerge(accounts);

            System.Console.WriteLine(res);
        }
    }
}



/**
 * 
[["John","johnsmith@mail.com","john_newyork@mail.com"],["John","johnsmith@mail.com","john00@mail.com"],["Mary","mary@mail.com"],["John","johnnybravo@mail.com"]]
 * 
 */
