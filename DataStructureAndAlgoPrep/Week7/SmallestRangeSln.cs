using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week7;

public class SmallestRangeSln
{
    /*
     * nums: There are K lists. Where on average, the size of each list is M.
     * Thus, there are at a minimum, K*M numbers.
     */
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        PriorityQueue<int, (int value, int listIndex, int indexInList)> minHeap = new PriorityQueue<int, (int value, int listIndex, int indexInList)>(new MinHeapComparer());
        int min = int.MaxValue;
        int max = int.MinValue;
        int numberOfIterations = int.MaxValue;
        int smallestRange = 0;
        int globalMin = 0;
        int globalMax = 0;

        // O(K)
        foreach (var list in nums)
        {
            if (list.Count < numberOfIterations)
            {
                numberOfIterations = list.Count;
            }
        }

        // Init the algorithm.
        for (int i = 0; i < nums.Count; ++i)
        {
            if (nums[i][0] < min)
            {
                min = nums[i][0];
            }

            if (nums[i][0] > max)
            {
                max = nums[i][0];
            }

            minHeap.Enqueue(nums[i][0], (value: nums[i][0], listIndex: i, indexInList: 0));
        }

        globalMin = min;
        globalMax = max;
        smallestRange = max - min;

        int iterationCounter = 1;

        while (true)
        {
            bool couldDequeue = minHeap.TryDequeue(out int value, out (int value, int listIndex, int indexInList) priority);

            if (!couldDequeue) throw new Exception();

            if (priority.indexInList + 1 >= nums[priority.listIndex].Count)
            {
                break;
            }

            int nextElement = nums[priority.listIndex][priority.indexInList + 1];

            if (nextElement > max)
            {
                max = nextElement;
            }

            minHeap.Enqueue(nextElement, (value: nextElement, listIndex: priority.listIndex, indexInList: priority.indexInList + 1));

            min = minHeap.Peek();

            if ((max - min) < smallestRange)
            {
                globalMax = max;
                globalMin = min;
                smallestRange = max - min;
            }

            iterationCounter = priority.indexInList + 1;
        }

        return new int[] { globalMin, globalMax };
    }

    public class MinHeapComparer : IComparer<(int value, int listIndex, int indexInList)>
    {
        public int Compare((int value, int listIndex, int indexInList) x, (int value, int listIndex, int indexInList) y)
        {
            return x.value - y.value;
        }
    }
}
