using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new CanAttendMeetingsSln();
            var meeetings = new int[2][];
            meeetings[0] = new int[2] { 7, 10 };
            meeetings[1] = new int[2] { 2, 4 };

            var sln = test.CanAttendMeetings(meeetings);

            System.Console.WriteLine(sln);
        }
    }
}
