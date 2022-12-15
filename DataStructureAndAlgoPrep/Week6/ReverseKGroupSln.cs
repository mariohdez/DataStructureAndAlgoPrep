using System;
using System.Collections.Generic;

using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6;

public class ReverseKGroupSln
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null) return null;

        int length = GetSize(head);
        int numberOfGroups = length / k;
        int leftOverNodes = length % k;

        IDictionary<int, ListNode> groupNumberToHeadOfGroup = new Dictionary<int, ListNode>();

        ListNode headOfRemainingList = head;
        ListNode currentGroupHead = null;
        ListNode currentGroupLastNode = headOfRemainingList;

        for (int i = 0; i < numberOfGroups; ++i)
        {
            currentGroupHead = headOfRemainingList;
            currentGroupLastNode = headOfRemainingList;
            for (int j = 0; j < k; ++j)
            {
                headOfRemainingList = headOfRemainingList.next;

                if (j + 1 != k)
                {
                    currentGroupLastNode = currentGroupLastNode.next;
                }
            }
            groupNumberToHeadOfGroup.Add(i, currentGroupHead);
            currentGroupLastNode.next = null;
        }


        for (int i = 0; i < numberOfGroups; ++i)
        {
            ListNode reveresedGroupHead = ReverseList(groupNumberToHeadOfGroup[i]);
            groupNumberToHeadOfGroup[i] = reveresedGroupHead;
        }

        ListNode headOfGroup = groupNumberToHeadOfGroup[0];
        ListNode currentOfGroup = headOfGroup;

        for (int i = 0; i < numberOfGroups - 1; ++i)
        {
            for (int j = 0; j < k - 1; ++j)
            {
                currentOfGroup = currentOfGroup.next;
            }

            ListNode headOfNextGroup = groupNumberToHeadOfGroup[i + 1];
            currentOfGroup.next = headOfNextGroup;
            currentOfGroup = currentOfGroup.next;
        }

        if (headOfRemainingList != null)
        {
            while (currentOfGroup != null && currentOfGroup.next != null)
            {
                currentOfGroup = currentOfGroup.next;
            }

            if (currentOfGroup != null)
            {
                currentOfGroup.next = headOfRemainingList;
            }
        }

        return headOfGroup;
    }

    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode previous = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return previous;
    }

    public int GetSize(ListNode head)
    {
        int size = 0;
        ListNode current = head;

        while (current != null)
        {
            current = current.next;
            size++;
        }

        return size;
    }
}