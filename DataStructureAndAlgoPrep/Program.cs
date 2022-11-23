using System;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week2;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode root = new TreeNode(2);
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);

            root.left = left;
            root.right = right;

            var test = new IsValidBinarySearchTreeSln();

            test.IsValidBST(root);
        }
    }
}
