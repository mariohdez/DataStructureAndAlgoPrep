using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class ReverseBits
    {
        public uint reverseBits(uint n)
        {
            uint reversedNumber = 0;

            for (int i = 0; i < 32; ++i)
            {
                uint bit = (n >> i) & 1;
                reversedNumber = reversedNumber | (bit << (31 - i));
            }

            return reversedNumber;
        }
    }
}
