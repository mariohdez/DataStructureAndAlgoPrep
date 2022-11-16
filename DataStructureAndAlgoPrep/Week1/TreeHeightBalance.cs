using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class TreeHeightBalance
    {
        public bool IsBalanced(TreeNode root)
        {
            return IsBalancedHelper(root).isBalanced;
        }

        public TreeInfo IsBalancedHelper(TreeNode root)
        {
            if (root == null)
            {
                return new TreeInfo
                {
                    height = 0,
                    isBalanced = true,
                };
            }

            var left = IsBalancedHelper(root.left);
            var right = IsBalancedHelper(root.right);

            if (Math.Abs(left.height - right.height) > 1 || !left.isBalanced || !right.isBalanced)

            {
                return new TreeInfo
                {
                    height = 1 + Math.Max(left.height, right.height),
                    isBalanced = false,
                };
            }

            return new TreeInfo
            {
                height = 1 + Math.Max(left.height, right.height),
                isBalanced = true,
            };
        }

        public bool IsBalancedTopDown(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var leftHeight = height(root.left);
            var rightHeight = height(root.right);

            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return false;
            }

            return IsBalancedTopDown(root.left) && IsBalancedTopDown(root.right);
        }

        public int height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftHeight = height(root.left);
            var rightHeight = height(root.right);

            var maxHeight = Math.Max(leftHeight, rightHeight);

            return 1 + maxHeight;
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;
    }

    public class TreeInfo
    {
        public int height { get; set; }
        public bool isBalanced { get; set; }
    }
}
