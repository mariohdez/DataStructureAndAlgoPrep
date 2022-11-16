using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new IsSubtreeSln();

            var root2 = new TreeNode(4);

            var root1_rootleft_rootleft = new TreeNode(1);
            var root1_rootleft_rootright = new TreeNode(2);

            var root1_rootleft = new TreeNode(4) {left= root1_rootleft_rootleft,right= root1_rootleft_rootright,};
            var root1_rootright = new TreeNode(5);
            var root1 = new TreeNode(3) { left=root1_rootleft, right = root1_rootright };


            var sln = test.IsSubtree(root1, root2);

            System.Console.WriteLine(sln);
        }
    }
}
