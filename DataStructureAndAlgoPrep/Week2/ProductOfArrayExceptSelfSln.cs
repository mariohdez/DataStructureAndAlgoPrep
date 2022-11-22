using System;
namespace DataStructureAndAlgoPrep.Week2
{
    public class ProductOfArrayExceptSelfSln
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int prefix = 1;
            int postfix = 1;

            for (int i = 0; i < nums.Length; ++i)
            {
                answer[i] = prefix;
                prefix = prefix * nums[i];
            }

            for (int j = nums.Length - 1; j >= 0; --j)
            {
                answer[j] = answer[j] * postfix;
                postfix = postfix * nums[j];
            }

            return answer;
        }


        public int[] ProductExceptSelfLinearMemoryComplexity(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int[] prefixes = new int[nums.Length];
            int[] postfixes = new int[nums.Length];

            int prefix = 1;
            int postfix = 1;

            for (int i = 0; i < nums.Length; ++i)
            {
                prefixes[i] = prefix;
                prefix = prefix * nums[i];
            }

            for (int j = nums.Length - 1; j >= 0; --j)
            {
                postfixes[j] = postfix;
                postfix = postfix * nums[j];
            }

            for (int k = 0; k < nums.Length; ++k)
            {
                answer[k] = prefixes[k] * postfixes[k];
            }

            return answer;
        }
    }
}

