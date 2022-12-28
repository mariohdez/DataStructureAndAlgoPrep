using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week8;

public class EmployeeFreeTimeSln
{
    public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule)
    {
        IList<Interval> mergedIntervals = new List<Interval>();
        List<Interval> allIntervals = new List<Interval>();
        IList<Interval> freeTimes = new List<Interval>();

        if (schedule == null || schedule.Count == 0) return freeTimes;

        foreach (IList<Interval> employeeSchedule in schedule)
        {
            foreach (Interval shift in employeeSchedule)
            {
                allIntervals.Add(shift);
            }
        }

        allIntervals.Sort(new IntervalComparer());

        Interval previousInterval = new Interval(allIntervals[0].start, allIntervals[0].end);
        mergedIntervals.Add(previousInterval);

        for (int i = 1; i < allIntervals.Count; ++i)
        {
            Interval currentInterval = allIntervals[i];
            if (previousInterval.end >= currentInterval.start)
            {
                previousInterval.end = Math.Max(currentInterval.end, previousInterval.end);
            }
            else
            {
                previousInterval = new Interval(currentInterval.start, currentInterval.end);
                mergedIntervals.Add(previousInterval);
            }
        }

        previousInterval = new Interval(mergedIntervals[0].end, int.MaxValue);
        freeTimes.Add(previousInterval);

        for (int i = 1; i < mergedIntervals.Count; ++i)
        {
            Interval currentInterval = mergedIntervals[i];

            previousInterval.end = currentInterval.start;

            previousInterval = new Interval(currentInterval.end, int.MaxValue);
            freeTimes.Add(previousInterval);
        }

        if (freeTimes.Count > 1)
        {
            freeTimes.RemoveAt(freeTimes.Count - 1);
        }

        return freeTimes;
    }
}

public class IntervalComparer : IComparer<Interval>
{
    public int Compare(Interval a, Interval b)
    {
        if (a.start == b.start)
        {
            return a.end - b.end;
        }
        return a.start - b.start;
    }
}

public class Interval
{
    public int start;
    public int end;

    public Interval() { }
    public Interval(int _start, int _end)
    {
        start = _start;
        end = _end;
    }
}