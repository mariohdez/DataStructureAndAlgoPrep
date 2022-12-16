using System.Text;
using System.Collections.Generic;
using System;

namespace DataStructureAndAlgoPrep.Week6;

public class DecodeStringSln
{
    public string DecodeString(string s)
    {
        int i = s.Length - 1;
        Stack<string> stack = new Stack<string>();
        StringBuilder result = new StringBuilder();

        while (i > 0 && s[i] != ']')
        {
            i--;
        }

        result.Insert(0, s.Substring(i+1));

        while (i > -1)
        {
            if (s[i] == ']')
            {
                stack.Push(s[i].ToString());
                i--;
            }
            else if (char.IsLetter(s[i]))
            {
                stack.Push(s[i].ToString());
                i--;
            }
            else if (char.Equals(s[i], '['))
            {
                i--;
            }
            else if (char.IsDigit(s[i]))
            {
                int power = 0;
                int res = 0;

                while (i > -1 && char.IsDigit(s[i]))
                {
                    int digit = s[i] - '0';
                    res = (digit * (int)(Math.Pow(10, power))) + res;
                    power++;
                    i--;
                }
                string stringToRepeat = "";
                // here I know the digit, and chars should be set...
                while (!string.Equals(stack.Peek(), "]"))
                {
                    stringToRepeat += stack.Pop();
                }

                stack.Pop();

                StringBuilder strBuilder = new StringBuilder();

                for (int j = 0; j < res; ++j)
                {
                    strBuilder.Append(stringToRepeat);
                }

                if (stack.Count == 0)
                {
                    result.Insert(0, strBuilder);
                }
                else
                {
                    stack.Push(strBuilder.ToString());
                }
            }
        }
        StringBuilder remainder = new StringBuilder();
        while (stack.Count > 0 )
        {
            remainder.Append(stack.Pop());
        }

        if (remainder.Length > 0)
        {
            result.Insert(0, remainder);
        }

        return result.ToString();
    }
}
