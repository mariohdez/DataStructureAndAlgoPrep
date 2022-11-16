using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class IsSubtreeSln
	{
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null || subRoot == null) { return true; }
            var startingPoint = FindSubRootNodeInTree(root,subRoot.val);
            if (startingPoint == null) return false;

            return false;
        }

        public bool IsSubTreeValidator(TreeNode treeRoot1, TreeNode treeRoot2)
        {
            if (treeRoot1==null && treeRoot2 == null) return true;
            if (treeRoot1 != null && treeRoot2 == null) return true;
            if (treeRoot1 == null && treeRoot2 != null) return false;

            if (treeRoot1.val != treeRoot2.val) return false;

            var isLeftGood = IsSubTreeValidator(treeRoot1.left, treeRoot2.left);
            var isRightGood = IsSubTreeValidator(treeRoot1.right, treeRoot2.right);

            return isLeftGood && isRightGood;
        }

        public TreeNode FindSubRootNodeInTree(TreeNode root, int target)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == target)
            {
                return root;
            }

            var left = FindSubRootNodeInTree(root.left, target);
            var right = FindSubRootNodeInTree(root.right, target);

            if (left != null) return left;
            if (right != null) return right;

            return null;
        }
    }
}

