using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;
using DataStructureAndAlgoPrep.Week7;
using DataStructureAndAlgoPrep.Week8;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            // [[[1,3],[6,7]],
            // [[2,4]],
            // [[2,5],[9,12]]]
            var schedule = new List<IList<Interval>>
            {
                new List<Interval>
                {
                    new Interval(1, 3),
                    new Interval(6, 7),
                },
                new List<Interval>
                {
                    new Interval(2, 4),
                },
                new List<Interval>
                {
                    new Interval(2, 5),
                    new Interval(9, 12),
                },
            };

            var test = new EmployeeFreeTimeSln();
            var res = test.EmployeeFreeTime(schedule);
        }
    }
}
