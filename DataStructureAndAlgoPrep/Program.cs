using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ProductOfArrayExceptSelfSln();

            test.ProductExceptSelfLinearMemoryComplexity(new int[] { 1, 2, 3, 4 });
        }
    }
}
