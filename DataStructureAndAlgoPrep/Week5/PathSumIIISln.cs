using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week5
{
    public class PathSumIIISln
    {
        private int answer = 0;
        private IDictionary<long, int> prefixSumToFrequencyMap = new Dictionary<long, int>();

        public int PathSum(TreeNode root, int targetSum)
        {
            this.prefixSumToFrequencyMap.Add(0, 1);
            PathSumDFS(root, curSum: 0L, targetSum: targetSum);
            return answer;
        }

        public void PathSumDFS(TreeNode root, long curSum, int targetSum)
        {
            if (root == null)
                return;

            curSum += root.val;

            if (this.prefixSumToFrequencyMap.ContainsKey(curSum - targetSum))
            {
                this.answer += this.prefixSumToFrequencyMap[curSum - targetSum];
            }

            if (!this.prefixSumToFrequencyMap.ContainsKey(curSum))
            {
                this.prefixSumToFrequencyMap.Add(curSum, 0);
            }

            this.prefixSumToFrequencyMap[curSum] = this.prefixSumToFrequencyMap[curSum] + 1;

            PathSumDFS(root.left, curSum, targetSum);
            PathSumDFS(root.right, curSum, targetSum);

            this.prefixSumToFrequencyMap[curSum] = this.prefixSumToFrequencyMap[curSum] - 1;
        }
    }
}
