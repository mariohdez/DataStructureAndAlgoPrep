using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week5
{
    public class RangeBstSumSln
    {
        private int answer = 0;

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return this.answer;
        }

        public void DFS(TreeNode root, int low, int high)
        {
            if (root == null) return;

            if (low <= root.val && root.val <= high)
            {
                answer += root.val;
            }

            if (low < root.val)
            {
                DFS(root.left, low, high);
            }

            if (root.val < high)
            {
                DFS(root.right, low, high);
            }
        }
    }
}

