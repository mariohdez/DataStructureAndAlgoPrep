using System;
using System.Collections.Generic;
namespace DataStructureAndAlgoPrep.Week4
{
    public class TaskSchedulerSln
    {
        public int LeastInterval(char[] tasks, int n)
        {
            PriorityQueue<char, int> maxHeap = new PriorityQueue<char, int>(comparer: new MaxComparer());
            IDictionary<char, int> taskFrequencyMap = new Dictionary<char, int>();

            Queue<(char, int, int)> q = new Queue<(char, int, int)>();
            int time = 0;

            for (int i = 0; i < tasks.Length; ++i)
            {
                if (!taskFrequencyMap.ContainsKey(tasks[i]))
                {
                    taskFrequencyMap.Add(tasks[i], 0);
                }

                taskFrequencyMap[tasks[i]] += 1;
            }

            foreach (KeyValuePair<char, int> keyValuePair in taskFrequencyMap)
            {
                maxHeap.Enqueue(keyValuePair.Key, keyValuePair.Value);
            }

            while (maxHeap.Count != 0 || q.Count != 0)
            {
                time += 1;

                if (maxHeap.Count != 0)
                {
                    maxHeap.TryPeek(out var element, out var pri);
                    pri -= 1;
                    if (pri > 0)
                    {
                        q.Enqueue((element, pri, time + n));
                    }
                }

                if (q.Count != 0 && q.Peek().Item3 == time)
                {
                    var item = q.Dequeue();
                    maxHeap.Enqueue(item.Item1, item.Item2);
                }
            }

            return time;
        }

        public class MaxComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y - x;
            }
        }
    }
}
