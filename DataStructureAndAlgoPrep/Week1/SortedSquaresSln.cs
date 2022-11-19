using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class SortedSquaresSln
	{
        public int[] SortedSquares(int[] nums)
        {
            int[] answer = new int[nums.Length];
            var leftPtr = 0;
            var rightPtr = nums.Length - 1;
            var answerPtr = nums.Length - 1;

            while (leftPtr <= rightPtr)
            {
                var squaredFromLeft = nums[leftPtr] * nums[leftPtr];
                var squaredFromRight = nums[rightPtr] * nums[rightPtr];

                if (squaredFromLeft > squaredFromRight)
                {
                    answer[answerPtr] = squaredFromLeft;
                    leftPtr++;
                }
                else
                {
                    answer[answerPtr] = squaredFromRight;
                    rightPtr--;
                }
                answerPtr--;
            }

            return answer;
        }
    }
}

