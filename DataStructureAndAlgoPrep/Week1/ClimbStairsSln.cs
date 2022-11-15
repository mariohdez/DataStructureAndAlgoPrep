using System;
namespace DataStructureAndAlgoPrep.Week1
{
	public class ClimbStairsSln
	{
		// n = 1, ways = 1 (1)
		// n = 2, ways = 2 (1,1) => (2)
		// n = 3, ways = 3 (1, 1, 1), (1, 2), (2, 1)
		// n = 4, ways =   (1, 1, 1, 1), (1, 1, 2), (1, 2, 1)
		public int ClimbStairs(int n)
		{
			int[] dp = new int[n+1];
			dp[1] = 1;
            dp[2] = 2;

            if (n == 1 || n == 2)
			{
				return dp[n];
			}

			for (int i = 3; i <= n; ++i)
			{
				dp[i] = dp[i - 1] + dp[i - 2];
			}

			return dp[n - 1];
        }

		public int ClimbStairsHelper(int currentStep, int finalStep)
		{
			if (currentStep > finalStep)
			{
				return 0;
			}

			if (currentStep == finalStep)
			{
				return 1;
			}

			return ClimbStairs(1 + currentStep, finalStep) + ClimbStairs(2 + currentStep, finalStep);
        }
	}
}

