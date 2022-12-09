using System;
using DataStructureAndAlgoPrep.Week1;

namespace DataStructureAndAlgoPrep.Week5
{
    public class InorderSuccessorSln
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode current = root;
            TreeNode successor = null;

            while (current != null)
            {
                if (current.val <= p.val)
                {
                    current = current.right;
                }
                else
                {
                    successor = current;
                    current = current.left;
                }
            }

            return successor;
        }
    }
}


/*
 * case 1: the in order successor is the parent.
 *          this happens when i went from parent, to parent.left
 * case 2: the in order success is the right pointer.
 *          this happens when I went from parent, to parent.right
 * case 3: the in order successor does not exist?
 *          this happens when, I went from parent, to parent.right and the current node's right does not exist
 * case 4: if parent is null, the success has to be either the right, or does not exist
 *
 */