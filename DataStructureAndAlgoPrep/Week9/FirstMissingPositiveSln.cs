using System;

public class FirstMissingPositiveSln
{
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] < 0)
            {
                nums[i] = 0;
            }
        }

        int len = nums.Length;

        for (int i = 0; i < len; ++i)
        {
            int val = Math.Abs(nums[i]);
            if (1 <= val && val <= len)
            {
                if (nums[val - 1] > 0)
                {
                    nums[val - 1] *= -1;
                }
                else if (nums[val - 1] == 0)
                {
                    nums[val - 1] = -1 * (len + 1);
                }
            }
        }

        for (int i = 1; i < len + 1; ++i)
        {
            if (nums[i - 1] >= 0)
            {
                return i;
            }
        }

        return len + 1;
    }
}
