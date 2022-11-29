using System;
namespace DataStructureAndAlgoPrep.Week3
{
    public class CanPartitionSln
    {
        private bool[][] memo;
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            memo = new bool[nums.Length+1][];
            
            for (int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];
            }


            if ((sum % 2) != 0) return false;

            int target = sum / 2;

            for (int i = 0; i <= nums.Length; ++i)
            {
                memo[i] = new bool[target + 1];
            }

            return DFS(nums, 0, 0, target);
        }

        public bool DFS(int[] nums, int index, int partialSum, int target)
        {
            if (partialSum > target) return false;
            if (index >= nums.Length) return false;

            if (partialSum == target) return true;

            int currentValue = nums[index];

            bool withValue = DFS(nums, index + 1, partialSum + currentValue, target);
            bool withoutValue = DFS(nums, index + 1, partialSum, target);
            return withValue || withoutValue;
        }
    }
}
