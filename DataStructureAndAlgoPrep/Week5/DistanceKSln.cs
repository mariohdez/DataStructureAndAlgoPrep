using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class DistanceKSln
    {
        private IDictionary<TreeNode, IList<TreeNode>> adjacencyGraph = new Dictionary<TreeNode, IList<TreeNode>>();

        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            ISet<TreeNode> visited = new HashSet<TreeNode>();
            IList<int> result = new List<int>();
            int numberOfNodesInLevel = 0;
            int distance = 0;
            BuildGraph(root, null);

            queue.Enqueue(target);
            visited.Add(target);


            while (queue.Count > 0 && distance <= k)
            {
                numberOfNodesInLevel = queue.Count;

                for (int i = 0; i < numberOfNodesInLevel; ++i)
                {
                    TreeNode node = queue.Dequeue();

                    if (distance == k)
                    {
                        result.Add(node.val);
                    }

                    foreach (TreeNode neighbor in adjacencyGraph[node])
                    {
                        if (visited.Contains(neighbor))
                        {
                            continue;
                        }

                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }

                distance++;
            }

            return result;
        }

        public void BuildGraph(TreeNode currentNode, TreeNode parent)
        {
            if (currentNode == null)
            {
                return;
            }

            if (!this.adjacencyGraph.ContainsKey(currentNode))
            {
                this.adjacencyGraph.Add(currentNode, new List<TreeNode>());
            }

            if (parent != null)
            {
                this.adjacencyGraph[currentNode].Add(parent);

                if (!this.adjacencyGraph.ContainsKey(parent))
                {
                    this.adjacencyGraph.Add(parent, new List<TreeNode>());
                }

                this.adjacencyGraph[parent].Add(currentNode);
            }

            BuildGraph(currentNode.left, currentNode);
            BuildGraph(currentNode.right, currentNode);
        }
    }
}
