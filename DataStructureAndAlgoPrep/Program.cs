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
            var test = new Codec();

            int[] nums = new int[] { 0 };
            // "1,2,3,NULL,NULL,4,NULL,NULL,5,NULL,NULL"

            var res = test.deserialize("1,2,3,NULL,NULL,4,NULL,NULL,5,NULL,NULL");

            System.Console.WriteLine(res);
        }
    }
}
