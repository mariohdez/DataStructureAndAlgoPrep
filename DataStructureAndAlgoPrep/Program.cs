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
            var test = new SortColorsSln();
            var colros = new int[] { 2,0,2,1,1,0, };
            test.SortColors(colros);
        }
    }
}
