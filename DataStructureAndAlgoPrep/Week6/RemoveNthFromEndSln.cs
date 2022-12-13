using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6
{
    public class RemoveNthFromEndSln
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int i = 0;
            int cnt = 0;
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && i <= n)
            {
                fast = fast.next;
                i++;
                cnt++;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
                cnt++;
            }

            if (cnt == n)
            {
                head = head.next;
            }
            else
            {
                if (slow.next != null)
                {
                    slow.next = slow.next.next;
                }
            }

            return head;
        }
    }
}
