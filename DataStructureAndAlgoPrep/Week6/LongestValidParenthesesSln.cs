using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class LongestValidParenthesesSln
{
    public int LongestValidParentheses(string s)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);
        int longestValidParentheses = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                if (stack.Peek() != -1 && s[stack.Peek()] == '(')
                {
                    stack.Pop();
                    int leftBoundry = stack.Peek();
                    int rightBoundry = i;

                    longestValidParentheses = Math.Max(longestValidParentheses, rightBoundry - leftBoundry);
                }
                else
                {
                    stack.Push(i);
                }
            }
        }

        return longestValidParentheses;
    }
}
