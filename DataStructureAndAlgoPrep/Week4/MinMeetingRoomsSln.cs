using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class MinMeetingRoomsSln
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, (int[] x, int[] y) =>
            {
                int diff = x[0] - y[0];

                if (diff == 0)
                {
                    return x[1] - y[1];
                }

                return diff;
            });

            PriorityQueue<int[], int> minHeap = new PriorityQueue<int[], int>();

            if (intervals.Length == 0)
            {
                return minHeap.Count;
            }

            minHeap.Enqueue(intervals[0], intervals[0][1]);

            for (int i = 1; i < intervals.Length; ++i)
            {
                int[] currentMeeting = intervals[i];
                int currentMeetingStart = currentMeeting[0];
                int currentMeetingEnd = currentMeeting[1];

                if (minHeap.Count > 0 && currentMeetingStart >= minHeap.Peek()[1])
                {
                    minHeap.Dequeue();
                }
                minHeap.Enqueue(currentMeeting, currentMeeting[1]);
                
            }

            return minHeap.Count;
        }
    }
}
