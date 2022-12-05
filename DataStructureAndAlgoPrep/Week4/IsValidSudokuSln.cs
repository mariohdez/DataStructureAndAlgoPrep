using System;
namespace DataStructureAndAlgoPrep.Week4
{
    public class IsValidSudokuSln
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; ++i)
            {
                if (!IsRowValid(board, i) || !IsColumnValid(board, i)) return false;

            }

            for (int subGridNumber = 0; subGridNumber < 9; ++subGridNumber)
            {
                if (!IsSubGridValid(board, subGridNumber)) return false;
            }

            return true;
        }

        public bool IsSubGridValid(char[][] board, int subGridNumber)
        {
            int[] valueFreqMap = new int[9];
            int rowStart = 3 * (subGridNumber / 3);
            int rowEnd = rowStart + 3;
            int colStart = (subGridNumber % 3) * 3;
            int colEnd = colStart + 3;

            for (int row = rowStart; row < rowEnd; ++row)
            {
                for (int col = colStart; col < colEnd; ++col)
                {
                    if (board[row][col] == '.') continue;

                    if (++valueFreqMap[board[row][col] - '0' - 1] > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsRowValid(char[][] board, int row)
        {
            int[] valueFreqMap = new int[9];

            for (int column = 0; column < board[0].Length; ++column)
            {
                if (board[row][column] == '.') continue;

                if (++valueFreqMap[board[row][column] - '0' - 1] > 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsColumnValid(char[][] board, int column)
        {
            int[] valueFreqMap = new int[9];

            for (int row = 0; row < board.Length; ++row)
            {
                if (board[row][column] == '.') continue;

                if (++valueFreqMap[board[row][column] - '0' - 1] > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
