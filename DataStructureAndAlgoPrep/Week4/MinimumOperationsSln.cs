using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class MinimumOperationsSln
    {
        public int MinimumOperations(int[] nums)
        {
            ISet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (num == 0)
                {
                    continue;
                }
                set.Add(num);
            }

            return set.Count;
        }

        public int MinimumOperationsSubOptimal(int[] nums)
        {
            int numberOfOperations = 0;

            Array.Sort(nums);
            int i = 0;

            while (i < nums.Length)
            {
                while (i < nums.Length && nums[i] == 0) i++;

                if (!(i < nums.Length)) break;

                int valueToReduce = nums[i];

                for (int k = i; k < nums.Length; ++k)
                {
                    nums[k] -= valueToReduce;
                }
                numberOfOperations++;
                i++;
            }

            return numberOfOperations;
        }
    }
}
