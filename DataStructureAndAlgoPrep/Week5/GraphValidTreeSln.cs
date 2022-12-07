using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class GraphValidTreeSln
    {
        public bool ValidTree(int n, int[][] edges)
        {
            if (edges == null)
                return true;

            if (edges.Length != n - 1)
                return false;

            IDictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>();
            ISet<int> visited = new HashSet<int>();
            IDictionary<int, int> currentNodeToParentNodeMap = new Dictionary<int, int>();

            foreach (int[] edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                {
                    graph.Add(edge[0], new List<int>());
                }

                if (!graph.ContainsKey(edge[1]))
                {
                    graph.Add(edge[1], new List<int>());
                }

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            try
            {
                currentNodeToParentNodeMap.Add(0, -1);

                DFS(graph, 0, visited, currentNodeToParentNodeMap);
            }
            catch (CycleDetectionException)
            {
                return false;
            }

            return currentNodeToParentNodeMap.Count == n;
        }


        public void DFS(IDictionary<int, IList<int>> adjacencyGraph, int currentNode, ISet<int> visited, IDictionary<int, int> currentNodeToParentNodeMap)
        {
            if (!adjacencyGraph.ContainsKey(currentNode))
            {
                return;
            }

            if (visited.Contains(currentNode))
            {
                throw new CycleDetectionException();
            }

            visited.Add(currentNode);

            foreach (int neighbor in adjacencyGraph[currentNode])
            {
                if (currentNodeToParentNodeMap[currentNode] == neighbor)
                {
                    continue;
                }

                if (!currentNodeToParentNodeMap.ContainsKey(neighbor))
                {
                    currentNodeToParentNodeMap.Add(neighbor, currentNode);
                }
                else
                {
                    currentNodeToParentNodeMap[neighbor] = currentNode;
                }

                DFS(
                    adjacencyGraph: adjacencyGraph,
                    currentNode: neighbor,
                    visited: visited,
                    currentNodeToParentNodeMap: currentNodeToParentNodeMap);
            }
        }

        public class CycleDetectionException : Exception { }
    }
}
