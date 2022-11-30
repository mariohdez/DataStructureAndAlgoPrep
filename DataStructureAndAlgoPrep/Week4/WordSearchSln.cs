using System;
namespace DataStructureAndAlgoPrep.Week4
{
    public class WordSearchSln
    {
        private int[][] directions = new int[4][]
        {
            new int[2] { -1,  0 },
            new int[2] {  1,  0 },
            new int[2] {  0, -1 },
            new int[2] {  0,  1 },
        };

        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; ++i)
            {
                for (int j = 0; j < board[0].Length; ++j)
                {
                    if (board[i][j] == word[0] && DFS(board, word, 0, i, j))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DFS(char[][] board, string word, int currentWordIndex, int currentRow, int currentCol)
        {
            // We found the word.
            if (currentWordIndex >= word.Length)
            {
                return true;
            }

            // Out of bounds.
            if (currentRow < 0 || currentRow >= board.Length || currentCol < 0 || currentCol >= board[0].Length)
            {
                return false;
            }

            // We have already visted this item.
            if (board[currentRow][currentCol] == '#')
            {
                return false;
            }

            if (board[currentRow][currentCol] != word[currentWordIndex])
            {
                return false;
            }

            // mark this square as visited.
            char previousChar = board[currentRow][currentCol];
            board[currentRow][currentCol] = '#';
            var exists = false;
            foreach (var direction in this.directions)
            {
                exists = exists || DFS(
                    board: board,
                    word: word,
                    currentWordIndex: currentWordIndex + 1,
                    currentRow: currentRow + direction[0],
                    currentCol: currentCol + direction[1]);
            }

            board[currentRow][currentCol] = previousChar;

            return exists;
        }
    }
}
