using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week2
{
    public class IsValidBinarySearchTreeSln
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBSTWithBoundries(root, null, null);
        }

        public bool IsValidBSTWithBoundries(TreeNode root, int? leftBoundry, int? rightBoundry)
        {
            if (root == null) return true;

            if (root.left != null && root.left.val >= root.val)
                return false;

            if (leftBoundry.HasValue && root.left != null && root.left.val <= leftBoundry.Value)
            {
                return false;
            }

            if (root.right != null && root.right.val <= root.val)
            {
                return false;
            }

            if (rightBoundry.HasValue && root.right != null && root.right.val >= rightBoundry.Value)
            {
                return false;
            }

            return IsValidBSTWithBoundries(root.left, leftBoundry, root.val) &&
                IsValidBSTWithBoundries(root.right, root.val, rightBoundry);
        }
    }
}

