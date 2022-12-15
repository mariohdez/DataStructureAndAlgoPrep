using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class LargestRectangleAreaSln
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights == null || heights.Length == 0) return 0;
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);
        int n = heights.Length;
        int largestRectangle = int.MinValue;

        for (int i = 0; i < heights.Length; ++i)
        {
            while (stack.Peek() != -1 && heights[stack.Peek()] >= heights[i])
            {
                int index = stack.Pop();
                int currentHeight = heights[index];
                int rightBoundry = i;
                int leftBoundry = stack.Peek();
                int width = rightBoundry - leftBoundry - 1;

                largestRectangle = Math.Max(largestRectangle, width * currentHeight);
            }

            stack.Push(i);
        }


        while (stack.Peek() != -1)
        {
            int currentHeight = heights[stack.Pop()];
            int width = n - stack.Peek() - 1;
            largestRectangle = Math.Max(largestRectangle, currentHeight * width);
        }

        return largestRectangle;
    }
}
