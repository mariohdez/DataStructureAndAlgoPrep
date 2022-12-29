using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataStructureAndAlgoPrep.Week8;

public class MaxSlidingWindowSln
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int[] maxSlidingWindow = new int[nums.Length - k + 1];
        int left = 0;
        int right = 0;
        int maxSlidingWindowIndex = 0;
        LinkedList<int> deque = new LinkedList<int>();

        while (right < nums.Length)
        {
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[right])
            {
                deque.RemoveLast();
            }

            deque.AddLast(right);

            // left val from window
            if (left > deque.First.Value)
            {
                deque.RemoveFirst();
            }

            if (right+1 >= k)
            {
                maxSlidingWindow[maxSlidingWindowIndex] = nums[deque.First.Value];
                maxSlidingWindowIndex++;
                left++;
            }

            right++;
        }
        
        return maxSlidingWindow;
    }
}
