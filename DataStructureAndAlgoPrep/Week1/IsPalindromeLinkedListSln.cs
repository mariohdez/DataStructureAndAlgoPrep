using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
	public class IsPalindromeLinkedListSln
	{
        private ListNode outsideHead = null;

        public bool IsPalindrome(ListNode head)
        {
            // O(1) memory
            // find the mid point of the list
            // reverse the second half
            // ensure the two halfs are equal. continue to compare the two lists while both of there pointers are non null. This will handle the "odd" case
            // reverse the second half back to normal.
            // return the result.

            ListNode headOfFirstHalf = head;
            ListNode endOfFirstHalf = GetMiddleNode(head);
            ListNode headOfSecondHalf = endOfFirstHalf.next;

            var reversedSecondHalfHead = reverseLinkedList(headOfSecondHalf);

            var temphead1 = headOfFirstHalf;
            var tempHead2 = reversedSecondHalfHead;
            bool isPalindrome = true;

            while (isPalindrome && tempHead2 != null)
            {
                if (temphead1.val != tempHead2.val)
                {
                    isPalindrome = false;
                }

                temphead1 = temphead1.next;
                tempHead2 = tempHead2.next;
            }



            var undoneReversalHead = reverseLinkedList(reversedSecondHalfHead);

            endOfFirstHalf.next = undoneReversalHead;

            return isPalindrome;
        }

        public ListNode reverseLinkedList(ListNode head)
        {
            ListNode previous = null;
            ListNode current = head;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = previous;

                previous = current;
                current = next;
            }

            return previous;
        }

        public ListNode GetMiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        public bool IsPalindromeRecursiveAndLinearMemoryComplexity(ListNode head)
        {
            this.outsideHead = head;

            return IsPalindromeHelper(head);
        }

        public bool IsPalindromeHelper(ListNode current)
        {
            if (current == null)
            {
                return true;
            }

            var res = IsPalindromeHelper(current.next);

            if (!res) return false;
            if (current.val != this.outsideHead.val) return false;
            this.outsideHead = this.outsideHead.next;

            return true;
        }


        public bool IsPalindromeIterativeAndLinearMemoryComplexity(ListNode head)
        {
            IList<ListNode> list = new List<ListNode>();
            ListNode current = head;
            int ptr1 = 0;
            int ptr2 = 0;

            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            ptr2 = list.Count - 1;

            while (ptr1 <= ptr2)
            {
                if (list[ptr1].val != list[ptr2].val)
                {
                    return false;
                }

                ptr1++;
                ptr2--;
            }

            return true;
        }
    }
}

