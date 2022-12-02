using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week4
{
    public class CalculateSln
    {
        public int EvaluateStack(Stack<string> stack)
        {
            int result = 0;

            if (stack.Count == 0 || (stack.TryPeek(out var temp) && !int.TryParse(stack.Peek(), out int digit)))
            {
                stack.Push(string.Format("{0}", 0));
            }

            result = int.Parse(stack.Pop());

            while (stack.Count != 0
                && char.TryParse(stack.Peek(), out char possibleClosingParenthese) && possibleClosingParenthese != ')')
            {
                string sign = stack.Pop();
                int nextOperand = int.Parse(stack.Pop());

                if (string.Equals(sign, "+"))
                {

                    result += nextOperand;
                }
                else
                {
                    result -= nextOperand;
                }

            }

            return result;
        }

        public int Calculate(string s)
        {
            int operand = 0;
            int n = 0;
            Stack<string> stack = new Stack<string>();

            for (int i = s.Length - 1; i >= 0; --i)
            {
                if (char.IsDigit(s[i]))
                {
                    operand = (int)(Math.Pow(10, n)) * (s[i] - '0') + operand;
                    n++;
                }
                else
                {
                    if (n > 0)
                    {
                        stack.Push(string.Format("{0}", operand));
                        operand = 0;
                        n = 0;
                    }

                    if (s[i] == '(')
                    {
                        int evaluationResult = EvaluateStack(stack);
                        stack.Pop();
                        stack.Push(string.Format("{0}", evaluationResult));
                    }
                    else if (s[i] != ' ')
                    {
                        stack.Push(string.Format("{0}", s[i]));
                    }
                    else
                    {
                        // ignore space?
                    }
                }
            }

            if (n > 0)
            {
                stack.Push(string.Format("{0}", operand));
                operand = 0;
                n = 0;
            }

            int test = EvaluateStack(stack);

            return test;
        }
    }
}
