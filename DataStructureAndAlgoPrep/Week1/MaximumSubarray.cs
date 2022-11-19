using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = dp[0];

            for (int i = 1; i < nums.Length; ++i)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
                max = Math.Max(max, dp[i]);
            }
            return max;
        }

    }
}
