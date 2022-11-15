using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class ReverseLinkedListSln
	{
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode previous = ReverseList(head.next);

            head.next.next = head;
            head.next = null;

            return previous;
        }

        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null) return null;

            ListNode current = head;
            ListNode previous = null;
            ListNode next = head.next;

            while (current != null)
            {
                next = current.next;
                current.next = previous;

                previous = current;
                current = next;
            }

            return previous;
        }
    }
}

