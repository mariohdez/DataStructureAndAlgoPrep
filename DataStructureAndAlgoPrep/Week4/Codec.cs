using System;
using System.Text;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class Codec
    {
        private const string NullMarker = "NULL";
        private void PreOrderTraversal(TreeNode root, StringBuilder strBuilder)
        {
            if (root == null)
            {
                strBuilder.Append(NullMarker + ",");
                return;
            }

            strBuilder.Append(root.val + ",");
            PreOrderTraversal(root.left, strBuilder);
            PreOrderTraversal(root.right, strBuilder);
        }

        public string serialize(TreeNode root)
        {
            StringBuilder strBuilder = new StringBuilder();

            PreOrderTraversal(root, strBuilder);
            strBuilder.Remove(strBuilder.Length - 1, 1);
            return strBuilder.ToString();
        }

        private TreeNode Construct(LinkedList<string> nodes)
        {
            if (string.Equals(nodes.First.Value, NullMarker))
            {
                nodes.RemoveFirst();
                return null;
            }

            TreeNode root = new TreeNode(int.Parse(nodes.First.Value));
            nodes.RemoveFirst();
            root.left = Construct(nodes);
            root.right = Construct(nodes);

            return root;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            LinkedList<string> nodes = new LinkedList<string>(data.Split(","));

            var root = Construct(nodes);

            return root;
        }
    }
}
