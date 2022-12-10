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
            var nine = new TreeNode(9);
            var twenty = new TreeNode(20);
            var fifteen = new TreeNode(15);
            var seven = new TreeNode(7);

            root.left = nine;
            root.right = twenty;
            twenty.left = fifteen;
            twenty.right = seven;

            var test = new ZigzagLevelOrderSln();
            var res = test.ZigzagLevelOrder(root);

            Console.WriteLine(res);
        }
    }
}
