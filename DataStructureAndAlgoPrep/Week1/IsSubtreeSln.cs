using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class IsSubtreeSln
	{
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null || subRoot == null)
            {
                return root == subRoot; // edge case of both being null to return true.
            }

            var currentRootIsSame = IsSameTree(root, subRoot);

            return currentRootIsSame || IsSameTree(root.left, subRoot.left) || IsSameTree(root.right, subRoot.right);
        }

        public bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;

            if (root1 != null && root2 != null && root1.val == root2.val)
                return IsSameTree(root1.left, root2.left) && IsSameTree(root1.right, root2.right);

            return false;
        }
    }
}

