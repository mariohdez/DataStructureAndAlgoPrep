using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class SubarraySumSln
    {
        public int SubarraySum(int[] nums, int k)
        {
            int answer = 0;
            IDictionary<int, int> prefixSumToFrequencyMap = new Dictionary<int, int>();
            prefixSumToFrequencyMap.Add(0, 1);
            int prefixSum = 0;
            int targetValue = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                prefixSum += nums[i];
                targetValue = prefixSum - k;
                if (prefixSumToFrequencyMap.ContainsKey(targetValue))
                {
                    answer += prefixSumToFrequencyMap[targetValue];
                }

                if (!prefixSumToFrequencyMap.ContainsKey(prefixSum))
                {
                    prefixSumToFrequencyMap.Add(prefixSum, 0);
                }

                prefixSumToFrequencyMap[prefixSum] += 1;
            }

            return answer;
        }
    }
}
