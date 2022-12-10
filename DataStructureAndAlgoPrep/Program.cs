using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;
using DataStructureAndAlgoPrep.Week3;
using DataStructureAndAlgoPrep.Week4;
using DataStructureAndAlgoPrep.Week5;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(3);
            var five = new TreeNode(5);
            var one = new TreeNode(1);
            var six = new TreeNode(6);
            var two = new TreeNode(2);
            var zero = new TreeNode(0);
            var eight = new TreeNode(8);
            var seven = new TreeNode(7);
            var four = new TreeNode(4);
            root.left = five;
            root.right = one;
            five.left = six;
            five.right = two;
            one.left = zero;
            one.right = eight;
            two.left = seven;
            two.right = four;


            var test = new DistanceKSln();
            var res = test.DistanceK(root, target: five, k: 2);

            Console.WriteLine(res);
        }
    }
}
