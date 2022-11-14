using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class MissingNumberSln
    {
        public int MissingNumber(int[] nums)
        {
            int missingNumber = nums.Length;

            for (int i = 0; i < nums.Length; ++i)
            {
                missingNumber = (missingNumber ^ nums[i]) ^ i;
            }

            return missingNumber;
        }
    }
}
