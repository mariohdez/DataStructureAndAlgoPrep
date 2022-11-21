using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class ThreeSumSln
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> triplelets = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; ++i)
            {
                int a = nums[i];
                if (i > 0 && a == nums[i - 1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int currentSum = nums[left] + nums[right];
                    int target = 0 - a;
                    if (target == currentSum)
                    {
                        triplelets.Add(new List<int> { a, nums[left], nums[right] });
                        left++;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                    }
                    else if (target > currentSum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return (IList<IList<int>>) triplelets;
        }
    }
}
