using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week5
{
    public class OddEvenListSln
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            ListNode headOfOdd = head;
            ListNode curOfOdd = headOfOdd;

            ListNode headOfEven = null;
            ListNode curOfEven = null;
            if (head.next != null)
            {
                headOfEven = head.next;
                curOfEven = headOfEven;
            }
            else
            {
                return head;
            }

            while (curOfOdd.next != null && curOfEven.next != null)
            {
                curOfOdd.next = curOfOdd.next.next;
                curOfOdd = curOfOdd.next;

                curOfEven.next = curOfEven.next.next;
                if (curOfEven.next == null)
                    break;
                curOfEven = curOfEven.next;
            }

            curOfOdd.next = headOfEven;
            curOfEven.next = null;

            return headOfOdd;
        }
    }
}
