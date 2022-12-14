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
            ListNode l1_0 = new ListNode(1);
            ListNode l1_1 = new ListNode(2);


            l1_0.next = l1_1;

            var test = new RotateRightSln();
            test.RotateRight(l1_0, 2);
        }
    }
}
