using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6
{
    public class SolveNQueensSln
    {
        private List<IList<string>> validBoards = new List<IList<string>>();
        private ISet<int> invalidColumns = new HashSet<int>();
        private ISet<int> invalidPositiveDiagonals = new HashSet<int>();
        private ISet<int> invalidNegativeDiagonals = new HashSet<int>();
        private const char Queen = 'Q';
        private const char EmptySpace = '.';
        private int targetQueens;
        private int N;

        public IList<IList<string>> SolveNQueens(int n)
        {
            char[][] board = new char[n][];
            this.targetQueens = n;
            this.N = n;

            for (int row = 0; row < n; ++row)
            {
                board[row] = new char[n];
                for (int c = 0; c < n; ++c)
                {
                    board[row][c] = EmptySpace;
                }
            }

            DFS(board, row: 0, queens: 0);

            return this.validBoards;
        }

        public void DFS(char[][] board, int row, int queens)
        {
            if (this.targetQueens == queens)
            {
                IList<string> rowsOfBoard = new List<string>();
                for (int r = 0; r < this.N; ++r)
                {
                    string str = "";
                    for (int c = 0; c < this.N; ++c)
                    {
                        str += board[r][c];

                    }
                    rowsOfBoard.Add(str);
                }

                this.validBoards.Add(rowsOfBoard);
                return;
            }

            for (int c = 0; c < this.N; ++c)
            {
                int negativeDiagonalPosition = row - c;
                int positiveDiagonalPosition = row + c;

                if (this.invalidColumns.Contains(c) || this.invalidNegativeDiagonals.Contains(negativeDiagonalPosition) || this.invalidPositiveDiagonals.Contains(positiveDiagonalPosition))
                {
                    continue;
                }

                board[row][c] = Queen;
                this.invalidColumns.Add(c);
                this.invalidNegativeDiagonals.Add(negativeDiagonalPosition);
                this.invalidPositiveDiagonals.Add(positiveDiagonalPosition);

                DFS(board, row + 1, queens + 1);

                board[row][c] = EmptySpace;
                this.invalidColumns.Remove(c);
                this.invalidNegativeDiagonals.Remove(negativeDiagonalPosition);
                this.invalidPositiveDiagonals.Remove(positiveDiagonalPosition);
            }
        }
    }
}
