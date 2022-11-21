using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class EvalRevPolNotSln
    {
        public int EvalRPN(string[] tokens)
        {
            if (tokens == null) return 0;
            Stack<int> stack = new Stack<int>();
            int pointer = 0;

            while (pointer < tokens.Length)
            {
                if (!int.TryParse(tokens[pointer], out int value))
                {
                    int rightHandSide = stack.Pop();
                    int leftHandSide = stack.Pop();
                    string operation = tokens[pointer];
                    stack.Push(Compute(operation, rightHandSide, leftHandSide));
                }
                else
                {
                    stack.Push(value);
                }

                pointer++;
            }

            return stack.Pop();
        }

        public int Compute(string operation, int rightHandSide, int leftHandSide)
        {
            if (operation.Equals("+"))
            {
                return leftHandSide + rightHandSide;
            }
            else if (operation.Equals("-"))
            {
                return leftHandSide - rightHandSide;
            }
            else if (operation.Equals("*"))
            {
                return leftHandSide * rightHandSide;
            }
            else if (operation.Equals("/"))
            {
                return leftHandSide / rightHandSide;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}

