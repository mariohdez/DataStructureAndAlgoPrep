using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class LongestConsecutiveSln
    {
        public int LongestConsecutive(int[] nums)
        {
            ISet<int> numberSet = new HashSet<int>();
            int longestSequence = int.MinValue;

            foreach (int number in nums)
            {
                numberSet.Add(number);
            }

            foreach (int number in nums)
            {
                if (!numberSet.Contains(number - 1))
                {
                    int currentNumber = number;
                    int sequenceLength = 0;
                    while (numberSet.Contains(currentNumber))
                    {
                        currentNumber += 1;
                        sequenceLength += 1;
                    }

                    longestSequence = Math.Max(longestSequence, sequenceLength);
                }
            }

            return longestSequence;
        }
    }
}
