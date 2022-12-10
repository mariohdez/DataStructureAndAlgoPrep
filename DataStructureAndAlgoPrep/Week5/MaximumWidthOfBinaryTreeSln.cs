using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week5
{
    public class MaximumWidthOfBinaryTreeSln
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            int maxWidth = int.MinValue;
            int numberOfNodesInLevel = 0;
            Queue<(TreeNode node, int index)> queue = new Queue<(TreeNode node, int index)>();

            if (root == null) return 0;

            queue.Enqueue((node: root, index: 1));

            (TreeNode node, int index) current = (null, 0);
            while (queue.Count > 0)
            {
                numberOfNodesInLevel = queue.Count;
                (TreeNode head, int headIndex) head = queue.Peek();
                for (int i = 0; i < numberOfNodesInLevel; ++i)
                {
                    current = queue.Dequeue();

                    if (current.node.left != null)
                    {
                        queue.Enqueue((current.node.left, 2 * current.index));
                    }

                    if (current.node.right != null)
                    {
                        queue.Enqueue((current.node.right, (2 * current.index) + 1));
                    }
                }
                maxWidth = Math.Max(maxWidth, current.index - head.headIndex + 1);
            }

            return maxWidth;
        }
    }
}
