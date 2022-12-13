using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week6
{
    public class AddTwoNumbersSln
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carryOver = 0;
            int temp = 0;
            ListNode cur1 = l1;
            ListNode cur2 = l2;
            ListNode result = new ListNode(-1);
            ListNode curResult = result;

            while (cur1 != null && cur2 != null)
            {
                temp = carryOver + cur1.val + cur2.val;
                ListNode tempNode = new ListNode(temp % 10);

                curResult.next = tempNode;

                carryOver = temp / 10;

                cur1 = cur1.next;
                cur2 = cur2.next;
                curResult = curResult.next;
            }

            int leftOverCarryOver = carryOver;

            // then still have some left in cur1 list
            if (cur1 != null)
            {
                curResult = AddRemainingDigitsToResult(cur1, curResult, carryOver);
                leftOverCarryOver = 0;
            }

            // then still have some left in cur2 list
            if (cur2 != null)
            {
                curResult = AddRemainingDigitsToResult(cur2, curResult, carryOver);
                leftOverCarryOver = 0;
            }

            if (leftOverCarryOver > 0)
            {
                curResult.next = new ListNode(leftOverCarryOver);
            }

            return result.next;
        }

        public ListNode AddRemainingDigitsToResult(ListNode headOfRemainingList, ListNode curResultNode, int carryOver)
        {
            ListNode tempCurRemainingList = headOfRemainingList;

            while (tempCurRemainingList != null)
            {
                int temp = tempCurRemainingList.val + carryOver;

                ListNode tempNode = new ListNode(temp % 10);
                curResultNode.next = tempNode;

                carryOver = temp / 10;
                tempCurRemainingList = tempCurRemainingList.next;
                curResultNode = curResultNode.next;
            }

            if (carryOver != 0)
            {
                ListNode tempNode = new ListNode(carryOver);
                curResultNode.next = tempNode;
            }

            return curResultNode;
        }
    }
}
