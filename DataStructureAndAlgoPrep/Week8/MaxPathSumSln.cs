
using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week8;

public class MaxPathSumSln
{
    private int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root)
    {
        MaxPathSumHelper(root);

        return this.maxSum;
    }

    public int MaxPathSumHelper(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Math.Max(MaxPathSumHelper(root.left), 0);
        int right = Math.Max(MaxPathSumHelper(root.right), 0);

        this.maxSum = Math.Max(this.maxSum, left + right + root.val);

        return Math.Max(left + root.val, right + root.val);
    }
}
