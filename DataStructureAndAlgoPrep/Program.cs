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
            // [,null,1000000000,null,1000000000,null,1000000000]

            TreeNode root = new TreeNode(1000000000);
            TreeNode left1 = new TreeNode(1000000000);
            TreeNode left2 = new TreeNode(294967296);
            TreeNode left3 = new TreeNode(1000000000);
            TreeNode left4 = new TreeNode(1000000000);
            TreeNode left5 = new TreeNode(1000000000);

            root.left = left1;
            left1.left = left2;
            left2.left = left3;
            left3.left = left4;


            var test = new PathSumIIISln();
            var res = test.PathSum(root: root, targetSum: 0);

            Console.WriteLine(res);
        }
    }
}
