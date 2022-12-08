using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class FindCheapestPriceSln
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            IDictionary<int, IList<(int city, int cost)>> adjacencyGraph = new Dictionary<int, IList<(int city, int cost)>>();
            Queue<(int city, int cost)> queue = new Queue<(int city, int cost)>();
            int level = -1;
            int numberOfCitiesInLevel = 0;

            for (int city = 0; city < n; ++city)
            {
                adjacencyGraph.Add(city, new List<(int destination, int cost)>());
            }

            foreach (int[] flightPath in flights)
            {
                int origin = flightPath[0];
                int destination = flightPath[1];
                int cost = flightPath[2];
                adjacencyGraph[origin].Add((destination, cost));
            }

            queue.Enqueue((src, 0));
            int? cheapest = null;

            while (queue.Count != 0)
            {
                numberOfCitiesInLevel = queue.Count;

                for (int i = 0; i < numberOfCitiesInLevel; ++i)
                {
                    (int city, int cost) currentCity = queue.Dequeue();

                    if (currentCity.city == dst)
                    {
                        if (cheapest == null)
                        {
                            cheapest = currentCity.cost;
                        }
                        else
                        {
                            cheapest = Math.Min(currentCity.cost, cheapest.Value);
                        }
                    }

                    foreach (var neighboringCity in adjacencyGraph[currentCity.city])
                    {
                        if (level + 1 > k)
                        {
                            continue;
                        }

                        queue.Enqueue((neighboringCity.city, currentCity.cost + neighboringCity.cost));
                    }
                }

                level++;
            }

            return cheapest == null ? -1 : cheapest.Value;
        }
    }
}
