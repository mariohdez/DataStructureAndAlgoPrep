using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MinMeetingRoomsSln();

            int[][] meetings = new int[6][]
            {
                new int[]{ 1, 10 },
                new int[]{ 2, 7 },
                new int[]{ 3, 19 },
                new int[]{ 8, 12 },
                new int[]{ 10, 20 },
                new int[]{ 11, 30 },
            };

            int res = test.MinMeetingRooms(meetings);

            Console.WriteLine(res);
        }
    }
}
