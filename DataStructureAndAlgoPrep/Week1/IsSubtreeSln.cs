using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class IsSubtreeSln
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;

            if (root == null)
            {
                return false;
            }

            if (IsSameTree(root, subRoot))
            {
                return true;
            }

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        public bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null) return root1 == root2;

            return root1.val == root2.val && IsSameTree(root1.left, root2.left) && IsSameTree(root1.right, root2.right);
        }
    }
}

