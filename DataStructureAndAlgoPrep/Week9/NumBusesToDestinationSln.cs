using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week9;

public class NumBusesToDestinationSln
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        IDictionary<int, ISet<int>> stopsToRoutesMap = new Dictionary<int, ISet<int>>();
        Queue<int> queue = new Queue<int>();

        for (int routeID = 0; routeID < routes.Length; ++routeID)
        {
            for (int stopCounter = 0; stopCounter < routes[routeID].Length; ++stopCounter)
            {
                int stopID = routes[routeID][stopCounter];
                if (!stopsToRoutesMap.ContainsKey(stopID))
                {
                    stopsToRoutesMap.Add(stopID, new HashSet<int>());
                }

                stopsToRoutesMap[stopID].Add(routeID);
            }
        }

        queue.Enqueue(source);
        ISet<int> vistedStop = new HashSet<int>();
        ISet<int> vistedRoute = new HashSet<int>();
        int numberOfBuses = 0;

        while (queue.Count > 0)
        {
            int numberOfStopsInThisLevel = queue.Count;

            for (int i = 0; i < numberOfStopsInThisLevel; ++i)
            {
                int stopID = queue.Dequeue();

                if (stopID == target)
                {
                    return numberOfBuses;
                }

                ISet<int> routesThatPassThroughThisStop = stopsToRoutesMap[stopID];

                foreach (int passingRoute in routesThatPassThroughThisStop)
                {
                    if (vistedRoute.Contains(passingRoute))
                    {
                        continue;
                    }


                    vistedRoute.Add(passingRoute);

                    foreach (int nextStop in routes[passingRoute])
                    {
                        if (vistedStop.Contains(nextStop))
                        {
                            continue;
                        }

                        vistedStop.Add(nextStop);
                        queue.Enqueue(nextStop);
                    }
                }
            }

            numberOfBuses++;
        }

        return -1;
    }
}
