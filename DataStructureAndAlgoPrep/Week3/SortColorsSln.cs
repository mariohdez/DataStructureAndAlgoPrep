using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class SortColorsSln
    {
        public void SortColors(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int i = 0;

            while (i <= right)
            {
                if (nums[i] == 0)
                {
                    // swap with left poitner
                    Swap(nums, left, i);
                    left++;
                }
                else if (nums[i] == 2)
                {
                    // swap with right pointer
                    Swap(nums, i, right);
                    right--;
                    i--;
                }
                i++;
            }
        }

        public void Swap(int[] nums, int indexA, int indexB)
        {
            int tempValueAtIndexA = nums[indexA];
            nums[indexA] = nums[indexB];
            nums[indexB] = tempValueAtIndexA;
        }

        public void BucketSortColors(int[] nums)
        {
            Dictionary<int, int> colorToFrequencyMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (!colorToFrequencyMap.ContainsKey(nums[i]))
                {
                    colorToFrequencyMap.Add(nums[i], 1);
                }
                else
                {
                    colorToFrequencyMap[nums[i]] += 1;
                }
            }

            int numsIndex = 0;
            for (int i = 0; i < 3; ++i)
            {
                if (!colorToFrequencyMap.ContainsKey(i))
                {
                    continue;
                }

                int frequency = colorToFrequencyMap[i];
                int k = 0;
                while (k < frequency)
                {
                    nums[numsIndex] = i;
                    numsIndex++;
                    k++;
                }
            }
        }
    }
}
