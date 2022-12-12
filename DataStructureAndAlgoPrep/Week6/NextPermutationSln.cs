using System;
namespace DataStructureAndAlgoPrep.Week6
{
    public class NextPermutationSln
    {
        public void NextPermutation(int[] nums)
        {
            if (nums == null) return;

            int pivot = nums.Length-1;
            int i = nums.Length - 1;

            while (pivot >= 1 && nums[pivot] <= nums[pivot - 1])
            {
                pivot--;
            }

            int indexOfValueLeftOfPeak = pivot - 1;
            int swapIndex = nums.Length - 1;

            if (pivot > 0)
            {
                while (indexOfValueLeftOfPeak >= 0 && nums[indexOfValueLeftOfPeak] >= nums[swapIndex])
                {
                    swapIndex--;
                }

                int temp = nums[pivot - 1];
                nums[pivot - 1] = nums[swapIndex];
                nums[swapIndex] = temp;
            }

            Reverse(nums, pivot);
        }

        public void Reverse(int[] nums, int start)
        {
            int end = nums.Length - 1;
            int temp = 0;

            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;

                start++;
                end--;
            }
        }
    }
}
