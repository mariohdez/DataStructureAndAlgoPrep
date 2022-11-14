using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class SingleNumberSln
    {
        public int SingleNumber(int[] nums)
        {
            int missingValue = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                missingValue = missingValue ^ nums[i];
            }

            return missingValue;
        }
    }
}
