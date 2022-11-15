using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
	public class MajorityElementSln
	{
        public int MajorityElement(int[] nums)
        {
            (int value, int count) majorityElement = (int.MinValue, int.MinValue);

            for (int i = 0; i < nums.Length; ++i)
            {
                if (majorityElement.count == 0)
                {
                    majorityElement = (nums[i], 1);
                    continue;
                }

                majorityElement.count += nums[i] == majorityElement.value ? 1 : -1;
            }

            return majorityElement.value;
        }

        public int MajorityElementLinearMemoryComplexity(int[] nums)
        {
            IDictionary<int, int> integerFrequency = new Dictionary<int, int>();
            int maxFrequency = int.MinValue;
            int majorityValue = int.MinValue;
            for (int i = 0; i < nums.Length; ++i)
            {
                int value = nums[i];
                if (!integerFrequency.ContainsKey(value))
                {
                    integerFrequency.Add(value, 1);
                }
                else
                {
                    integerFrequency[value] = integerFrequency[value] + 1;
                }
            }

            foreach (KeyValuePair<int, int> integerFrequencyPair in integerFrequency)
            {
                if (integerFrequencyPair.Value > maxFrequency)
                {
                    maxFrequency = integerFrequencyPair.Value;
                    majorityValue = integerFrequencyPair.Key;
                }
            }

            return majorityValue;
        }
    }
}

