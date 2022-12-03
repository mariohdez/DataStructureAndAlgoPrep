using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week4
{
	public class MergeKSortedListsSln
	{
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

            // init heap.
            foreach (ListNode list in lists)
            {
                ListNode head = list;

                if (head != null)
                {
                    minHeap.Enqueue(head, head.val);
                }
            }

            if (minHeap.Count == 0) return null;

            var curNode = minHeap.Dequeue();
            if (curNode.next != null)
            {
                minHeap.Enqueue(curNode.next, curNode.next.val);
            }

            var headOfMergedList = curNode;
            var curNodeOfMergedList = curNode;


            while (minHeap.Count != 0)
            {
                curNode = minHeap.Dequeue();
                if (curNode.next != null)
                {
                    minHeap.Enqueue(curNode.next, curNode.next.val);
                }

                curNodeOfMergedList.next = curNode;

                curNodeOfMergedList = curNode;
            }



            return headOfMergedList;
        }

        public class ValueComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x - y;
            }
        }
    }
}

