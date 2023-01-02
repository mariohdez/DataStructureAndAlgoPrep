using System;

namespace DataStructureAndAlgoPrep.Week9;

public class FindMinSln
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length -1;
        int middle = ((right - left) / 2) + left;

        while (left <= right)
        {
            middle = ((right - left) / 2) + left;

            if (nums[middle] < nums[right])
            {
                // good case?
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return nums[middle];
    }
}