using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new IsPalindromeLinkedListSln();

            var secondOne = new ListNode(1);
            var secondTwo= new ListNode(2);
            var three = new ListNode(3);
            var firstTwo = new ListNode(2);
            var head = new ListNode(1);

            head.next = firstTwo;
            firstTwo.next = three;
            three.next = secondTwo;
            secondTwo.next = secondOne;


            var sln = test.IsPalindrome(head);

            System.Console.WriteLine(sln);
        }
    }
}
