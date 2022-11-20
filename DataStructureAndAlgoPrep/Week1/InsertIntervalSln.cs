using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week1
{
	public class InsertIntervalSln
	{
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            LinkedList<int[]> mergedIntervals = new LinkedList<int[]>();
            int idx = 0;

            while (idx < intervals.Length && intervals[idx][0] < newInterval[0])
            {
                mergedIntervals.AddLast(intervals[idx]);
                idx++;
            }

            if (mergedIntervals.Count == 0 || mergedIntervals.Last.Value[1] < newInterval[0])
            {
                mergedIntervals.AddLast(newInterval);
            }
            else
            {
                var newEnd = Math.Max(mergedIntervals.Last.Value[1], newInterval[1]);
                mergedIntervals.Last.Value[1] = newEnd;
            }

            while (idx < intervals.Length)
            {
                var nextIntervalCandidate = intervals[idx++];

                // no overlap, append
                if (mergedIntervals.Last.Value[1] < nextIntervalCandidate[0])
                {
                    mergedIntervals.AddLast(nextIntervalCandidate);
                }
                else // overlap, so merge.
                {
                    mergedIntervals.Last.Value[1] = Math.Max(mergedIntervals.Last.Value[1], nextIntervalCandidate[1]);
                }
            }

            return mergedIntervals.ToArray<int[]>();
        }
    }
}

