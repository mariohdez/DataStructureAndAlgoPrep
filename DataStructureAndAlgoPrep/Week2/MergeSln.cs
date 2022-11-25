using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week2
{
    public class MergeSln
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (int[] x, int[] y) => x[0] - y[0]);
            LinkedList<int[]> merged = new LinkedList<int[]>();

            for (int i = 0; i < intervals.Length; ++i)
            {
                if (merged.Count == 0 || intervals[i][0] > merged.Last.Value[1])
                {
                    merged.AddLast(intervals[i]);
                }
                else
                {
                    merged.Last.Value[1] = Math.Max(merged.Last.Value[1], intervals[i][1]);
                }
            }

            return merged.ToArray<int[]>(); ;
        }
    }

    public class Interval
    {
        public int Start { get; set; }

        public int End { get; set; }

        public Interval(int start, int end)
        { this.Start = start; this.End = end; }
    }

    public class IntervalComparer : IComparer<Interval>
    {
        public int Compare(Interval i1, Interval i2)
        {
            int xDiff = i1.Start - i2.Start;

            if (xDiff != 0)
            {
                return xDiff;
            }

            return i1.End - i2.End;
        }
    }
}
