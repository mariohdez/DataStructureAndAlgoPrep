using System;
using System.Reflection;

namespace DataStructureAndAlgoPrep.Week4
{
    public class RotateSln
    {
        public void Rotate(int[] nums, int k)
        {
            int swaps = 0;
            int numsLen = nums.Length;
            int currentIndex = 0;
            int nextIndex = 0;
            k = k % nums.Length;


            int previousValue = nums[currentIndex];
            int temp = previousValue;

            for (int start = 0; swaps < nums.Length; ++start)
            {
                currentIndex = start;
                previousValue = nums[start];

                do
                {
                    nextIndex = (currentIndex + k) % numsLen;
                    temp = nums[nextIndex];

                    nums[nextIndex] = previousValue;

                    previousValue = temp;

                    currentIndex = nextIndex;

                    swaps++;
                } while (start != currentIndex);
            }
        }
    }
}
