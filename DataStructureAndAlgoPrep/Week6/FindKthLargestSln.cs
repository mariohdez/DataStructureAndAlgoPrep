using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class FindKthLargestSln
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(new MinHeapComparer());

        for (int i = 0; i < nums.Length; ++i)
        {
            minHeap.Enqueue(nums[i], nums[i]);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        return minHeap.Dequeue();
    }


    public class MinHeapComparer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return a - b;
        }
    }
}
