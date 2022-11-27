using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week3
{
    public class BuildTreeFromInOrderAndPreOrder
    {
        private int preorderIndex = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> inOrderValueToIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; ++i)
            {
                inOrderValueToIndexMap.Add(inorder[i], i);
            }

            return BuildTreeDFS(
                left: 0,
                right: preorder.Length - 1,
                preorder: preorder,
                inOrderValueToIndexMap: inOrderValueToIndexMap);
        }

        public TreeNode BuildTreeDFS(int left, int right, int[] preorder, IDictionary<int, int> inOrderValueToIndexMap)
        {
            if (left > right) return null;
            int rootValue = preorder[this.preorderIndex++];
            int indexOfRootVal = inOrderValueToIndexMap[rootValue];

            TreeNode root = new TreeNode(rootValue);

            root.left = BuildTreeDFS(
                left: left,
                right: indexOfRootVal - 1,
                preorder: preorder,
                inOrderValueToIndexMap: inOrderValueToIndexMap);
            root.right = BuildTreeDFS(
                left: indexOfRootVal + 1,
                right: right,
                preorder: preorder,
                inOrderValueToIndexMap: inOrderValueToIndexMap);

            return root;
        }
    }
}
