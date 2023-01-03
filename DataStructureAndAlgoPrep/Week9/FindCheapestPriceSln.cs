using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week9;

public class FindCheapestPriceSln
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        int[] prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        for (int i = 0; i < k + 1; ++i)
        {
            int[] tempPrices = new int[n];
            Array.Copy(prices, tempPrices, n);

            foreach (var flight in flights)
            {
                int s = flight[0];
                int d = flight[1];
                int p = flight[2];
                if (prices[s] == int.MaxValue)
                {
                    continue;
                }

                if (prices[s] + p < tempPrices[d])
                {
                    tempPrices[d] = prices[s] + p;
                }
            }
            Array.Copy(tempPrices, prices, n);
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}
