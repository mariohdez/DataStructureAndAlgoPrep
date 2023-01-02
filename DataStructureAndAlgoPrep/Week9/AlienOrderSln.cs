using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week9;

public class AlienOrderSln
{
    public string AlienOrder(string[] words)
    {
        IDictionary<char, ISet<char>> adjacencyGraph = new Dictionary<char, ISet<char>>();

        // Add all the characters in the words as nodes.
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                if (!adjacencyGraph.ContainsKey(c))
                {
                    adjacencyGraph.Add(c, new HashSet<char>());
                }
            }
        }

        for (int i = 0; i < words.Length - 1; ++i)
        {
            string word1 = words[i];
            string word2 = words[i+1];
            if (word1.Length > word2.Length && word1.StartsWith(word2))
            {
                return string.Empty;
            }

            int len = Math.Min(word1.Length, word2.Length);

            for (int j = 0; j < len; ++j)
            {
                if (word1[j] != word2[j])
                {
                    adjacencyGraph[word1[j]].Add(word2[j]);
                    break;
                }
            }
        }

        // false => we have visted this character before
        // true => we have visited this character before and this character is in our current path...
        IDictionary<char, bool> visited = new Dictionary<char, bool>();
        IList<char> result = new List<char>();


        foreach (char c in adjacencyGraph.Keys)
        {
            if (DFS(adjacencyGraph, c, visited, result))
            {
                return string.Empty;
            }
        }

        StringBuilder strBuilder = new StringBuilder();

        for (int i = result.Count - 1; i >= 0; --i)
        {
            strBuilder.Append(result[i]);
        }

        return strBuilder.ToString();
    }

    public bool DFS(IDictionary<char, ISet<char>> graph, char currentNode, IDictionary<char, bool> visited, IList<char> result)
    {
        if (visited.ContainsKey(currentNode))
        {
            return visited[currentNode];
        }

        visited.Add(currentNode, true);

        foreach (char c in graph[currentNode])
        {
            if (DFS(graph, c, visited, result)) return true;
        }


        visited[currentNode] = false;
        result.Add(currentNode);

        return false;
    }
}
