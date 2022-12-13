using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6
{
    public class FurthestBuildingSln
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(new MinComparer());

            for (int i = 0; i < heights.Length - 1; ++i)
            {
                int heightDifference = heights[i + 1] - heights[i];

                if (heightDifference <= 0)
                    continue;

                if (ladders > 0)
                {
                    ladders--;
                    minHeap.Enqueue(heightDifference, heightDifference);
                }
                else
                {
                    bool successfulPeek = minHeap.TryPeek(out int smallestLadderAllocation, out _);

                    if (!successfulPeek || heightDifference < smallestLadderAllocation)
                    {
                        bricks -= heightDifference;
                    }
                    else
                    {
                        smallestLadderAllocation = minHeap.Dequeue();
                        minHeap.Enqueue(heightDifference, heightDifference);
                        bricks -= smallestLadderAllocation;
                    }

                    if (bricks < 0)
                    {
                        return i;
                    }
                }
            }

            return heights.Length - 1;
        }

        public class MinComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x - y;
            }
        }
    }
}
