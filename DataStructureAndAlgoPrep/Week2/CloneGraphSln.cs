using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class CloneGraphSln
    {
        Dictionary<Node, Node> visitedNodesToCreatedNodeCopy = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            if (visitedNodesToCreatedNodeCopy.ContainsKey(node))
            {
                return visitedNodesToCreatedNodeCopy[node];
            }


            Node cloneNode = new Node(node.val, new List<Node>());

            visitedNodesToCreatedNodeCopy.Add(node, cloneNode);

            for (int i = 0; i < node.neighbors.Count; ++i)
            {
                cloneNode.neighbors.Add(CloneGraph(node.neighbors[i]));
            }

            return cloneNode;
        }
    }
}
