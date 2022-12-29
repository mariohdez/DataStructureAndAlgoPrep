using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week8;

public class EraseOverlapIntervalSln
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        int removalCount = 0;
        Array.Sort(intervals, new IntervalComparer());

        int[] previousInterval = intervals[0];
        int[] currentInterval = null;

        for (int i = 1; i < intervals.Length; ++i)
        {
            currentInterval = intervals[i];
            if (DoIntervalsOverlap(previousInterval, currentInterval))
            {
                if (!(currentInterval[1] > previousInterval[1]))
                {
                    previousInterval = currentInterval;
                }

                removalCount++;
            }
            else
            {
                previousInterval = currentInterval;
            }
        }

        return removalCount;
    }

    public bool DoIntervalsOverlap(int[] a, int[] b)
    {
        int aEnd = a[1];
        int bStart = b[0];

        // If B starts before a ends, then there must be overlap.
        return bStart < aEnd;
    }

    public class IntervalComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x[0] == y[0])
            {
                return x[1] - y[1];
            }

            return x[0] - y[0];
        }
    }
}
