using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week1
{
    public class MoveZerosSln
    {
        public void MoveZeroes(int[] nums)
        {
            int lastKnownNonZero = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[lastKnownNonZero];
                    nums[lastKnownNonZero] = nums[i];
                    nums[i] = temp;
                    lastKnownNonZero++;
                }
            }
        }
    }
}

