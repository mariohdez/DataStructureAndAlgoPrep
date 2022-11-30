using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class BinarySearchTreeKthSmallest
    {
        private readonly IList<int> inOrderTraversalList = new List<int>();

        public int KthSmallest(TreeNode root, int k)
        {
            InOrderTraversal(root);

            return inOrderTraversalList[k - 1];
        }

        public void InOrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            InOrderTraversal(root.left);
            this.inOrderTraversalList.Add(root.val);
            InOrderTraversal(root.right);
        }
    }
}
