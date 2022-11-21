using System;
namespace DataStructureAndAlgoPrep.Week2
{
	public class TwoSumIISln
	{
        public int[] TwoSumII(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int currentSum = numbers[left] + numbers[right];
                if (target == currentSum)
                {
                    return new int[2] { left+1, right+1 };
                }
                else if (target > currentSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}

