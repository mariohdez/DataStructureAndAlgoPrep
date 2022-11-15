using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class CanAttendMeetingsSln
    {
        public class Interval
        {
            public int Start { get; set; }
            public int End { get; set; }
        }

        public class IntervalComparer : IComparer<Interval>
        {
            public int Compare(Interval a, Interval b)
            {
                return a.Start - b.Start;
            }
        }

        public bool CanAttendMeetings(int[][] intervals)
        {
            List<Interval> intervalList = new List<Interval>();
            for (int i = 0; i < intervals.Length; ++i)
            {
                intervalList.Add(new Interval
                {
                    Start = intervals[i][0],
                    End = intervals[i][1],
                });
            }

            intervalList.Sort(new IntervalComparer());

            if (intervalList.Count == 0)
            {
                return true;
            }

            var previousMeeting = intervalList[0];

            for  (int i = 1; i < intervalList.Count; ++i)
            {
                var currentMeeting = intervalList[i];
                if (currentMeeting.Start >= previousMeeting.Start)
                {
                    return false;
                }

                previousMeeting = currentMeeting;
            }

            return true;
        }
    }
}

