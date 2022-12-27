using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week8;

public class JobSchedulingSln
{
    private readonly int[] memo = new int[5001];

    public int FindNextJob(int[] startTime, int lastEndingTime)
    {
        int left = 0;
        int right = startTime.Length - 1;
        int nextIndex = startTime.Length;
        int mid = 0;

        while (left <= right)
        {
            mid = ((right - left) / 2) + left;

            if (startTime[mid] >= lastEndingTime)
            {
                nextIndex = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return nextIndex;
    }

    public int FindMaxProfit(IList<IList<int>> jobs, int[] startTime, int n, int position)
    {
        // 0 profit if we have iterated through all the jobs.
        if (position == n)
        {
            return 0;
        }

        // If we have calculated the max profit from here already, then return the result directly.
        if (this.memo[position] != -1)
        {
            return this.memo[position];
        }

        int nextIndex = FindNextJob(startTime, jobs[position][1]);

        int maxProfitIfSkip = FindMaxProfit(jobs, startTime, n, position + 1);
        int maxProfitIfSchedule = jobs[position][2] + FindMaxProfit(jobs, startTime, n, nextIndex);

        int max = Math.Max(maxProfitIfSchedule, maxProfitIfSkip);

        this.memo[position] = max;

        return this.memo[position];
    }

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        IList<IList<int>> jobs = new List<IList<int>>();
        int length = profit.Length;

        Array.Fill(this.memo, -1);

        for (int i = 0; i < length; ++i)
        {
            jobs.Add(new List<int>
            {
                startTime[i], endTime[i], profit[i],
            });
        }

        jobs = jobs.OrderBy((job) => job[0]).ToList<IList<int>>();

        for (int i = 0; i < length; ++i)
        {
            startTime[i] = jobs[i][0];
        }

        return FindMaxProfit(jobs, startTime, length, 0);
    }
}