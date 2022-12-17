using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class BasicCalculator2Sln
{
    public int Calculate(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        Stack<int> stack = new Stack<int>();
        int currentNumber = 0;
        char currentOperation = '+';
        int result = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            if (char.IsDigit(s[i]))
            {
                currentNumber = (currentNumber * 10) + s[i] - '0';
            }

            if (!char.IsWhiteSpace(s[i]) && !char.IsDigit(s[i]) || i == (s.Length - 1))
            {
                if (currentOperation == '+')
                {
                    stack.Push(currentNumber);
                }
                else if (currentOperation == '-')
                {
                    stack.Push(0 - currentNumber);
                }
                else if (currentOperation == '*')
                {
                    int left = stack.Pop();
                    int right = currentNumber;
                    stack.Push(left * right);
                }
                else if (currentOperation == '/')
                {
                    int left = stack.Pop();
                    int right = currentNumber;
                    stack.Push(left / right);
                }

                currentNumber = 0;
                currentOperation = s[i];
            }
        }

        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}
