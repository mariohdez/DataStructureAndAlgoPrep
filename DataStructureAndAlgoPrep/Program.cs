using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1->2->3->4->5->6
            // 1->N
            ListNode head = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(3);
            ListNode four = new ListNode(4);
            ListNode five = new ListNode(5);
            ListNode six = new ListNode(6);

            //head.next = two;
            //two.next = three;
            //three.next = four;
            //four.next = five;
            //five.next = six;

            var test = new OddEvenListSln();
            var res = test.OddEvenList(head);

            Console.WriteLine(res);
        }
    }
}
