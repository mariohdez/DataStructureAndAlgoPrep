using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
	public class BinaryTreeLevelOrderSln
	{
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> levelOrder = new List<IList<int>>();
            if (root == null) return levelOrder;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count!=0)
            {
                int currentLevelLength = queue.Count;
                List<int> currentLevel = new List<int>();
                for (int i = 0; i < currentLevelLength; ++i)
                {
                    TreeNode node = queue.Dequeue();
                    currentLevel.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levelOrder.Add(currentLevel);
            }

            return levelOrder;
        }
    }
}

