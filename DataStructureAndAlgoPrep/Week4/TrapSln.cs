using System;
namespace DataStructureAndAlgoPrep.Week4
{
    public class TrapSln
    {
        public int Trap(int[] height)
        {
            int rainWaterTrapped = 0;
            if (height == null || height.Length == 0) return rainWaterTrapped;

            int[] leftMaxes = new int[height.Length];
            int[] rightMaxes = new int[height.Length];

            leftMaxes[0] = 0;
            rightMaxes[height.Length - 1] = 0;

            for (int i = 1; i < leftMaxes.Length; ++i)
            {
                leftMaxes[i] = Math.Max(leftMaxes[i - 1], height[i - 1]);
            }

            for (int i = height.Length - 2; i >= 0; --i)
            {
                rightMaxes[i] = Math.Max(rightMaxes[i + 1], height[i + 1]);
            }

            for (int i = 0; i < height.Length; ++i)
            {
                int rainCollected = Math.Min(leftMaxes[i], rightMaxes[i]) - height[i];

                if (rainCollected < 0)
                {
                    rainCollected = 0;
                }

                rainWaterTrapped += rainCollected;
            }

            return rainWaterTrapped;
        }
    }
}
