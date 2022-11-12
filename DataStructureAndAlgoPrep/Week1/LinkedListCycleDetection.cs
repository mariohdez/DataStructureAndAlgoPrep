using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class LinkedListCycleDetection
    {
        /*
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
Internally, pos is used to denote the index of the node that tail's next pointer is connected to.
Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

         */

        public bool HasCycle(ListNode head)
        {
            var slow = head;
            ListNode fast = null;
            if (head.next != null)
            {
                fast = head.next.next;
            }
            else
            {
                return false;
            }


            while (slow != null && fast != null)
            {
                if (fast == slow)
                {
                    return true;
                }

                if (fast.next == null)
                {
                    return false;
                }
                else
                {
                    fast = fast.next.next;
                }

                slow = slow.next;
                
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            this.val = x;
            next = null;
        }
    }
}
