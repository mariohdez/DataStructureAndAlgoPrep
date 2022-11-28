using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class SubSetsSln
    {
        private List<IList<int>> answer = new List<IList<int>>();

        public IList<IList<int>> Subsets(int[] nums)
        {
            this.backtracking(nums, 0, new LinkedList<int>());

            return this.answer;
        }

        public void backtracking(int[] nums, int currentIndex, LinkedList<int> currentSubset)
        {
            if (currentIndex >= nums.Length)
            {
                this.answer.Add(new List<int>(currentSubset));
                return;
            }

            // include the current index...
            currentSubset.AddLast(nums[currentIndex]);
            this.backtracking(nums, currentIndex + 1, currentSubset);


            // don't include current index...
            currentSubset.RemoveLast();
            this.backtracking(nums, currentIndex + 1, currentSubset);
        }
    }
}
