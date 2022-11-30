using System;
namespace DataStructureAndAlgoPrep.Week3
{
    public class MaxAreaSln
    {
        public int MaxArea(int[] height)
        {
            int maxArea = int.MinValue;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int width = right - left;
                int curHeight = Math.Min(height[left], height[right]);
                int currentArea = width * curHeight;

                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return maxArea;
        }
    }
}
