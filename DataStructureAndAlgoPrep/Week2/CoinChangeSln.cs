using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class CoinChangeSln
    {
        private Dictionary<int, int> remainingToMinCoinCount = new Dictionary<int, int>();

        public int CoinChange(int[] coins, int amount)
        {
            return CoinChangeHelper(amount, coins);
        }

        public int CoinChangeHelper(int currentValue, int[] coins)
        {
            if (currentValue < 0)
            {
                return -1;
            }

            if (currentValue == 0)
            {
                return 0;
            }

            if (remainingToMinCoinCount.ContainsKey(currentValue))
            {
                return remainingToMinCoinCount[currentValue];
            }

            int minCount = int.MaxValue;

            foreach (var denomination in coins)
            {
                int count = CoinChangeHelper(currentValue - denomination, coins);
                if (count == -1) continue;
                minCount = Math.Min(minCount, count + 1);
            }

            remainingToMinCoinCount.Add(currentValue, minCount == int.MaxValue ? -1 : minCount);

            return remainingToMinCoinCount[currentValue];
        }
    }
}
