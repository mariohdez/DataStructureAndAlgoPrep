using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class CountComponentsSln
    {
        public int CountComponents(int n, int[][] edges)
        {
            IDictionary<int, IList<int>> adjacencyGraph = new Dictionary<int, IList<int>>();
            IDictionary<int, int> nodeToParentMap = new Dictionary<int, int>();
            ISet<int> visited = new HashSet<int>();
            int components = 0;

            for (int node = 0; node < n; ++node)
            {
                adjacencyGraph.Add(node, new List<int>());
            }

            foreach (int[] edge in edges)
            {
                int nodeA = edge[0];
                int nodeB = edge[1];

                adjacencyGraph[nodeA].Add(nodeB);
                adjacencyGraph[nodeB].Add(nodeA);
            }
            
            for (int node = 0; node < n; ++node)
            {
                if (!visited.Contains(node))
                {
                    nodeToParentMap.Add(node, -1);
                    DFS(adjacencyGraph, node, visited, nodeToParentMap);
                    components++;
                }
            }

            return components;
        }


        public void DFS(IDictionary<int, IList<int>> adjacencyGraph, int currentNode, ISet<int> visited, IDictionary<int, int> nodeToParentMap)
        {
            if (visited.Contains(currentNode))
            {
                return;
            }

            visited.Add(currentNode);

            foreach (int neighbor in adjacencyGraph[currentNode])
            {
                if (nodeToParentMap[currentNode] == neighbor)
                {
                    continue;
                }

                if (!nodeToParentMap.ContainsKey(neighbor))
                {
                    nodeToParentMap.Add(neighbor, currentNode);
                }
                else
                {
                    nodeToParentMap[neighbor] = currentNode;
                }

                DFS(adjacencyGraph, neighbor, visited, nodeToParentMap);
            }
        }
    }
}
