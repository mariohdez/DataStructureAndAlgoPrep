using DataStructureAndAlgoPrep.Week1;
using System;

namespace DataStructureAndAlgoPrep.Week6;

public class ReorderListSln
{
    public void ReorderList(ListNode head)
    {
        ListNode midPoint = GetMidpoint(head);

        ListNode headOfSecondList = ReverseList(midPoint.next);

        ListNode headOfFirstList = head;
        midPoint.next = null;

        ListNode newHead = MergeLists(headOfFirstList, headOfSecondList);
    }

    public ListNode MergeLists(ListNode head1, ListNode head2)
    {
        ListNode ptr1 = head1;
        ListNode ptr2 = head2;
        ListNode temp = null;

        ListNode newHead = head1;

        while (ptr1 != null && ptr2 != null)
        {
            temp = ptr1.next;
            ptr1.next = ptr2;
            ptr1 = temp;
            temp = ptr2.next;
            ptr2.next = ptr1;
            ptr2 = temp;
        }

        return newHead;
    }

    public ListNode GetMidpoint(ListNode head)
    {
        if (head == null) return null;
        ListNode slowPointer = head;
        ListNode fastPointer = head.next;

        while (fastPointer != null && fastPointer.next != null)
        {
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;
        }

        return slowPointer;
    }

    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next==null)
        {
            return head;
        }

        ListNode previous = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return previous;
    }
}
