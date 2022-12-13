using System;
using System.Text;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6
{
    public class SwapPairsSln
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            ListNode current = head;
            ListNode neighbor = current.next;
            ListNode newHead = neighbor;

            if (neighbor == null)
            {
                return head;
            }

            while (current != null && neighbor != null)
            {
                current.next = neighbor.next;
                neighbor.next = current;
                current = current.next;
                if (current!=null)
                {
                    neighbor = current.next;
                }
            }

            return newHead;
        }
    }
}
