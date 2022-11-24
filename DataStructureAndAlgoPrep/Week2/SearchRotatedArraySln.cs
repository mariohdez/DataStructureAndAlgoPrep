using System;
namespace DataStructureAndAlgoPrep.Week2
{
    public class SearchRotatedArraySln
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            var middle = 0;

            while (left <= right)
            {
                middle = ((right - left) / 2) + left;
                if (target == nums[middle]) return middle;

                if (nums[left] <= nums[middle])
                {
                    if (target > nums[middle] || target < nums[left])
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
                else
                {
                    if (target < nums[middle] || target > nums[right])
                        right = middle - 1;
                    else
                        left = middle + 1;
                }

            }

            return -1;
        }
    }
}
