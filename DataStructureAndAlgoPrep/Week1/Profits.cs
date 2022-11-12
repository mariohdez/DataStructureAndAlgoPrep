using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class Profits
    {
        public int MaxProfits(int[] prices)
        {
            int min = int.MaxValue;
            int profits = 0;

            for (int i = 0; i < prices.Length; ++i)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > profits)
                {
                    profits = prices[i] - min;
                }
            }

            return profits;
        }
    }
}
