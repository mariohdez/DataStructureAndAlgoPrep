using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week8;

public class FindMaxLengthSln
{
    public int FindMaxLength(int[] nums)
    {
        int maxLength = 0;
        int count = 0;
        IDictionary<int, int> countToIndexMap = new Dictionary<int, int>();
        countToIndexMap.Add(0, -1);

        for (int i = 0; i < nums.Length; ++i)
        {
            count = count + (nums[i] == 0 ? -1 : 1);

            if (countToIndexMap.ContainsKey(count))
            {
                maxLength = Math.Max(maxLength, i - countToIndexMap[count]);
            }
            else
            {
                countToIndexMap.Add(count, i);
            }
        }

        return maxLength;
    }
}
