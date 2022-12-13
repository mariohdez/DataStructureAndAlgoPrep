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
            ListNode l1_0 = new ListNode(9);
            ListNode l1_1 = new ListNode(9);
            ListNode l1_2 = new ListNode(9);
            ListNode l1_3 = new ListNode(9);
            ListNode l1_4 = new ListNode(9);
            ListNode l1_5 = new ListNode(9);
            ListNode l1_6 = new ListNode(9);

            l1_0.next = l1_1;
            l1_1.next = l1_2;
            l1_2.next = l1_3;
            l1_3.next = l1_4;
            l1_4.next = l1_5;
            l1_5.next = l1_6;


            ListNode l2_0 = new ListNode(9);
            ListNode l2_1 = new ListNode(9);
            ListNode l2_2 = new ListNode(9);
            ListNode l2_3 = new ListNode(9);

            l2_0.next = l2_1;
            l2_1.next = l2_2;
            l2_2.next = l2_3;


            var test = new AddTwoNumbersSln();
            test.AddTwoNumbers(l1_0, l2_0);
        }
    }
}
