using System;
using DataStructureAndAlgoPrep.Week1;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class PathSumIISln
    {
        private List<IList<int>> paths = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, targetSum, 0, new List<int>());

            return null;
        }

        private void DFS(TreeNode root, int targetSum, int curSum, IList<int> currentPath)
        {
            if (root == null)
            {
                return;
            }

            curSum += root.val;
            currentPath.Add(root.val);

            if (root.left == null && root.right == null && curSum == targetSum)
            {
                this.paths.Add(new List<int>(currentPath));
            }

            DFS(root.left, targetSum, curSum, currentPath);
            DFS(root.right, targetSum, curSum, currentPath);

            currentPath.RemoveAt(currentPath.Count - 1);
            curSum -= root.val;
        }
    }
}
