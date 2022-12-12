using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week6
{
    public class GenerateParenthesisSln
    {
        private IList<string> parenthesis = new List<string>();

        public IList<string> GenerateParenthesis(int n)
        {
            DFS(n: n, new StringBuilder(), 0, 0);

            return this.parenthesis;
        }

        public void DFS(int n, StringBuilder strBuilder, int numberOfOpen, int numberOfClose)
        {
            if (numberOfOpen == numberOfClose && (numberOfOpen + numberOfClose) == n * 2)
            {
                this.parenthesis.Add(strBuilder.ToString());
                return;
            }

            if (numberOfOpen > n)
            {
                return;
            }

            if (numberOfClose > numberOfOpen)
            {
                return;
            }

            strBuilder.Append('(');
            DFS(n, strBuilder, numberOfOpen + 1, numberOfClose);
            strBuilder.Remove(strBuilder.Length - 1, 1);
            strBuilder.Append(')');
            DFS(n, strBuilder, numberOfOpen, numberOfClose + 1);
            strBuilder.Remove(strBuilder.Length - 1, 1);
        }
    }
}
