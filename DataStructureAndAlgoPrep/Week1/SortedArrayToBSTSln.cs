using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class SortedArrayToBSTSln
	{
        public TreeNode SortedArrayToBST(int[] nums)
        {
            var root = BuildBST(nums, 0, nums.Length - 1);

            return root;
        }

        public TreeNode BuildBST(int[] nums, int left, int right)
        {
            if (!(left <= right))
            {
                return null;
            }

            var mid = ((right - left) / 2) + left;

            var root = new TreeNode(nums[mid]);

            root.left = BuildBST(nums, left, mid - 1);
            root.right = BuildBST(nums, mid+1, right);

            return root;
        }
    }
}

