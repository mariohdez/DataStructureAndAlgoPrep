using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
	public class PermutationSln
	{
        private List<IList<int>> answer = new List<IList<int>>();
        private int targetSize = 0;

        public IList<IList<int>> Permute(int[] nums)
        {
            ISet<int> items = new HashSet<int>();
            targetSize = nums.Length;
            List<int> currentPermutation = new List<int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                items.Add(nums[i]);
            }

            PermuteHelper(new int[nums.Length], 0, items, nums.Length);

            return this.answer;
        }

        public void PermuteHelper(int[] currentPermuitation, int currentIndex, ISet<int> currentOptions, int targetLength)
        {
            if (currentIndex == targetLength)
            {
                this.answer.Add(new List<int>(currentPermuitation));
            }

            foreach (int option in currentOptions)
            {
                ISet<int> remainingOptions = new HashSet<int>(currentOptions);
                remainingOptions.Remove(option);

                currentPermuitation[currentIndex] = option;

                PermuteHelper(currentPermuitation, currentIndex + 1, remainingOptions, targetLength);

            }
        }
    }
}

