using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week5
{
    public class CourseScheduleIISln
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            IDictionary<int, IList<int>> prerequisiteCourseGraph = new Dictionary<int, IList<int>>();
            IDictionary<int, int> courseNumberToInDegreeMap = new Dictionary<int, int>();
            IList<int> order = new List<int>();
            LinkedList<int> sourceNodes = new LinkedList<int>();

            for (int course = 0; course < numCourses; ++course)
            {
                prerequisiteCourseGraph.Add(course, new List<int>());
                courseNumberToInDegreeMap.Add(course, 0);
            }

            foreach (int[] requirement in prerequisites)
            {
                int prerequisite = requirement[1];
                int course = requirement[0];
                courseNumberToInDegreeMap[course]++;

                prerequisiteCourseGraph[prerequisite].Add(course);
            }

            foreach (KeyValuePair<int, IList<int>> keyValuePair in prerequisiteCourseGraph)
            {
                if (courseNumberToInDegreeMap[keyValuePair.Key] == 0)
                {
                    sourceNodes.AddLast(keyValuePair.Key);
                }
            }

            int removeEdges = 0;

            while (sourceNodes.Count != 0)
            {
                int value = sourceNodes.First.Value;
                sourceNodes.RemoveFirst();
                order.Add(value);

                foreach (int course in prerequisiteCourseGraph[value])
                {
                    Console.WriteLine(courseNumberToInDegreeMap[course]);
                    courseNumberToInDegreeMap[course] -= 1;
                    removeEdges++;
                    Console.WriteLine(courseNumberToInDegreeMap[course]);

                    if (courseNumberToInDegreeMap[course] == 0)
                    {
                        sourceNodes.AddLast(course);
                    }
                }
            }

            if (removeEdges != prerequisites.Length) return (new List<int>()).ToArray<int>();

            return order.ToArray<int>();
        }
    }
}
