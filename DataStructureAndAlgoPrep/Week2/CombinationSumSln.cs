using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class CombinationSumSln
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> answer = new List<IList<int>>();

            Backtrack(candidates, target, 0, 0, new LinkedList<int>(), answer);

            return answer;
        }

        public void Backtrack(int[] candidates, int target, int startingIndex, int currentSum, LinkedList<int> combination, IList<IList<int>> results)
        {
            if (currentSum == target)
            {
                results.Add(new List<int>(combination));
                return;
            }

            if (currentSum > target)
            {
                return;
            }

            for (int i = startingIndex; i < candidates.Length; ++i)
            {
                combination.AddLast(candidates[i]);
                Backtrack(candidates, target, i, currentSum + candidates[i], combination, results);
                combination.RemoveLast();
            }
        }
    }
}

