using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class CountingBitsSln
    {
        public int[] CountingBits(int n)
        {
            int[] answer = new int[n + 1];
            int offset = 1;

            if (n == 0)
            {
                return answer;
            }

            answer[0] = 0;
            int curNumber = 1;

            while (curNumber <= n)
            {
                if (curNumber == 2*offset)
                {
                    offset *= 2;
                }
                answer[curNumber] = 1 + answer[curNumber - offset];
                curNumber++;
            }            

            return answer;
        }

        public int NumberOf1Bits(int n)
        {
            int numberOf1Bits = 0;
            int res = 0;
            while (n > 0)
            {
                res = n % 2;
                if (res == 1)
                {
                    numberOf1Bits++;
                }

                n /= 2;
            }

            return numberOf1Bits;
        }
    }
}
