using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6;

public class RotateRightSln
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null) return head;

        int listCount = GetListCount(head);

        if (listCount == 1) return head;

        int rotations = k % listCount;
        if (rotations == 0) return head;

        ListNode breakPointNode = GetBreakPointNode(head, listCount, rotations);

        ListNode newHead = breakPointNode.next;
        breakPointNode.next = null;

        ListNode currentNewList = newHead;

        while (currentNewList != null && currentNewList.next != null)
        {
            currentNewList = currentNewList.next;
        }

        currentNewList.next = head;

        return newHead;
    }

    public ListNode GetBreakPointNode(ListNode head, int sizeOfList, int numberOfRotations)
    {
        int breakPointEnd = sizeOfList - numberOfRotations - 1;
        ListNode current = head;

        for (int i = 0; i < breakPointEnd; ++i)
        {
            current = current.next;
        }

        return current;
    }

    public int GetListCount(ListNode head)
    {
        ListNode current = head;
        int count = 0;

        while (current != null)
        {
            current = current.next;
            count++;
        }

        return count;
    }
}