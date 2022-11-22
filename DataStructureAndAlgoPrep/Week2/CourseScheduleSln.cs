using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class CourseScheduleSln
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length == 0) return true;
            int totalDependencies = prerequisites.Length;
            Dictionary<int, GNode> graph = new Dictionary<int, GNode>();
            LinkedList<int> noDependencyNodes = new LinkedList<int>();

            foreach (var prerequisite in prerequisites)
            {
                GNode previousCourse;
                if (graph.ContainsKey(prerequisite[1]))
                {
                    previousCourse = graph[prerequisite[1]];
                }
                else
                {
                    previousCourse = new GNode(0);
                    graph.Add(prerequisite[1], previousCourse);
                }

                GNode nextCourse;
                if (graph.ContainsKey(prerequisite[0]))
                {
                    nextCourse = graph[prerequisite[0]];
                }
                else
                {
                    nextCourse = new GNode(0);
                    graph.Add(prerequisite[0], nextCourse);
                }

                previousCourse.OutNodes.Add(prerequisite[0]);
                nextCourse.InDegree += 1;
            }

            foreach (KeyValuePair<int, GNode> kvPair in graph)
            {
                if (kvPair.Value.InDegree == 0)
                {
                    noDependencyNodes.AddLast(kvPair.Key);
                }
            }
            
            int removedEdges = 0;

            while (noDependencyNodes.Count > 0)
            {
                int noDependencyNode = noDependencyNodes.First.Value;
                noDependencyNodes.RemoveFirst();

                foreach (int nextCourse in graph[noDependencyNode].OutNodes)
                {
                    GNode childNode = graph[nextCourse];
                    childNode.InDegree -= 1;
                    removedEdges += 1;
                    if (childNode.InDegree == 0)
                    {
                        noDependencyNodes.AddLast(nextCourse);
                    }
                }
            }

            return removedEdges == totalDependencies;
        }

        public class GNode
        {
            public int InDegree { get; set; }

            public List<int> OutNodes { get; set; } = new List<int>();

            public GNode(int inDegree)
            {
                this.InDegree = InDegree;
            }
        }
    }
}
