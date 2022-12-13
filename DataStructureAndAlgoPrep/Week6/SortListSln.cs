using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6;

public class SortListSln
{
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode left = head;
        ListNode right = GetMid(head);
        ListNode temp = right.next;

        right.next = null;
        right = temp;

        var leftList = SortList(left);
        var rightList = SortList(right);

        return MergeLists(leftList, rightList);
    }

    public ListNode MergeLists(ListNode head1, ListNode head2)
    {
        if (head1 == null || head2 == null) return head1 == null ? head2 : head1;

        ListNode dummyHead = new ListNode(-1);
        ListNode previousDummyHead = dummyHead;

        while (head1 != null && head2 != null)
        {
            if (head1.val < head2.val)
            {
                previousDummyHead.next = head1;
                head1 = head1.next;
            }
            else
            {
                previousDummyHead.next = head2;
                head2 = head2.next;
            }

            previousDummyHead = previousDummyHead.next;
        }

        if (head1 != null)
        {
            previousDummyHead.next = head1;
        }

        if (head2 != null)
        {
            previousDummyHead.next = head2;
        }

        return dummyHead.next;
    }

    public ListNode GetMid(ListNode head)
    {
        ListNode fastPointer = head.next;
        ListNode slowPointer = head;

        while (fastPointer != null && fastPointer.next != null)
        {
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;
        }

        return slowPointer;
    }
}
