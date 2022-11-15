using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class LinkedListCycleDetection
    {
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
