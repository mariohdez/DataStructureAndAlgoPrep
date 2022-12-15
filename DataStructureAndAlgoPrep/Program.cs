using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1_0 = new ListNode(1);
            ListNode l1_1 = new ListNode(2);
            ListNode l1_2 = new ListNode(3);
            ListNode l1_3 = new ListNode(4);
            ListNode l1_4 = new ListNode(5);
            ListNode l1_5 = new ListNode(6);
            ListNode l1_6 = new ListNode(7);


            l1_0.next = l1_1;
            l1_1.next = l1_2;
            l1_2.next = l1_3;
            l1_3.next = l1_4;
            l1_4.next = l1_5;
            l1_5.next = l1_6;

            var test = new ReverseKGroupSln();

            test.ReverseKGroup(l1_0,2);

        }
    }
}
