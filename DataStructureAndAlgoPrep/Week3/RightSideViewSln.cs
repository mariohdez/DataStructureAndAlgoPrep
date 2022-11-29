using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class RightSideViewSln
    {
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> rightSideView = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root == null) return rightSideView;

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int lengthOfLevel = queue.Count;

                for (int i = 0; i < lengthOfLevel; ++i)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    if (i + 1 == lengthOfLevel)
                    {
                        rightSideView.Add(node.val);
                    }
                }
            }

            return rightSideView;
        }
    }
}
