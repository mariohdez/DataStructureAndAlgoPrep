using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class FindClosestElementsSln
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        if (arr == null || arr.Length == 0) return null;

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(new DistanceComparer(x));

        foreach (int coordinate in arr)
        {
            minHeap.Enqueue(coordinate, coordinate);
        }

        int[] answer = new int[k];

        for (int i = 0; i < k; ++i)
        {
            answer[i] = minHeap.Dequeue();
        }

        Array.Sort(answer);

        return answer;
    }

    public class DistanceComparer : IComparer<int>
    {
        private readonly int centerPoint;

        public DistanceComparer(int centerPoint)
        {
            this.centerPoint = centerPoint;
        }

        public int Compare(int coordinateA, int coordinateB)
        {
            int distanceA = Math.Abs(coordinateA - this.centerPoint);
            int distanceB = Math.Abs(coordinateB - this.centerPoint);

            if (distanceA == distanceB)
            {
                return coordinateA - coordinateB;
            }

            return distanceA - distanceB;
        }
    }
}