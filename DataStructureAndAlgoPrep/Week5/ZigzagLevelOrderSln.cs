using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class ZigzagLevelOrderSln
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            int zigZagCounter = 0;
            int numberOfNodesOnLevel = 0;
            List<IList<int>> answer = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int[] levelAnswer;
            int levelAnswerIndex = 0;

            if (root == null) return answer;

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                numberOfNodesOnLevel = queue.Count;
                levelAnswer = new int[numberOfNodesOnLevel];
                bool isZigZagEven = zigZagCounter % 2 == 0;

                for (int i = 0; i < numberOfNodesOnLevel; ++i)
                {
                    TreeNode currentNode = queue.Dequeue();
                    levelAnswerIndex = isZigZagEven ? i : (numberOfNodesOnLevel - 1) - i;
                    levelAnswer[levelAnswerIndex] = currentNode.val;

                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }

                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }

                answer.Add(levelAnswer);
                zigZagCounter++;
            }

            return answer;
        }
    }
}
