using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week8;

public class ThreeSumClosestSln
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int n = nums.Length;
        Array.Sort(nums);
        int diff = int.MaxValue;
        int closestDiff = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                int currentDiff = target - sum;
                if (Math.Abs(currentDiff) < Math.Abs(diff))
                {
                    closestDiff = sum;
                    diff = Math.Abs(currentDiff);
                }

                if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return closestDiff;
    }
}
