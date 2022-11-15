using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ReverseLinkedListSln();

            var one = new ListNode(1);
            var two = new ListNode(2);
            var three = new ListNode(3);
            var four = new ListNode(4);
            var five = new ListNode(5);

            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = null;

            var sln = test.ReverseList(one);

            System.Console.WriteLine(sln);
        }
    }
}
