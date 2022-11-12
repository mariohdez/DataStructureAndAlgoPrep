using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class NumberOf1BIts
    {
        public int HammingWeight(uint n)
        {
            uint mask = 1;
            int numberOf1Bits = 0;

            for (int i = 0; i < 32; ++i)
            {
                if ((n & mask) != 0)
                {
                    numberOf1Bits++;
                }

                mask = mask << 1;
            }

            return numberOf1Bits;
        }
    }
}
