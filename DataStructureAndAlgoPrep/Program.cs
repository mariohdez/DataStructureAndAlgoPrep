using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            //ListNode two = new ListNode(2);
            //ListNode three = new ListNode(3);
            //ListNode four = new ListNode(4);
            //ListNode five = new ListNode(5);
            //one.next = two;
            //two.next = three;
            //three.next = four;
            //four.next = five;

            int n = 1;
            var test = new RemoveNthFromEndSln();
            test.RemoveNthFromEnd(one, n);
        }
    }
}
