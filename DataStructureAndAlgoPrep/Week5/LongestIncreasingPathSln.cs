using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class LongestIncreasingPathSln
    {
        private int LongestPath = int.MinValue;
        private int Rows;
        private int Columns;
        private int[][] longestPathsMemo;
        private int[][] directions = new int[4][]
        {
            new int[2] {  1,  0 },
            new int[2] { -1,  0 },
            new int[2] {  0,  1 },
            new int[2] {  0, -1 },
        };

        public int LongestIncreasingPath(int[][] matrix)
        {
            this.Rows = matrix.Length;
            this.Columns = matrix[0].Length;
            longestPathsMemo = new int[this.Rows][];

            for (int r = 0; r < this.Rows; ++r)
            {
                longestPathsMemo[r] = new int[this.Columns];
            }

            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Columns; ++c)
                {
                    DFS(matrix: matrix, row: r, column: c, previousValue: int.MinValue, pathLength: 0);
                }
            }

            int max = int.MinValue;

            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Columns; ++c)
                {
                    max = Math.Max(max, this.longestPathsMemo[r][c]);
                }
            }

            return max;
        }

        public int DFS(int[][] matrix, int row, int column, int previousValue, int pathLength)
        {
            // can't go here bc we're outta bounds.
            if (row < 0 || row >= this.Rows || column < 0 || column >= this.Columns)
            {
                return 0;
            }

            // Can't visit here bc i've been here before.
            if (matrix[row][column] == -1)
            {
                return 0;
            }

            // Can't visit here bc the path is not increasing.
            if (matrix[row][column] <= previousValue)
            {
                return 0;
            }

            if (this.longestPathsMemo[row][column] != 0)
            {
                return this.longestPathsMemo[row][column];
            }

            int value = matrix[row][column];
            matrix[row][column] = -1;

            foreach (int[] direction in this.directions)
            {
                DFS(matrix, row + direction[0], column + direction[1], value, pathLength + 1);
            }

            int up = DFS(matrix, row, column - 1, value, pathLength + 1);
            int down = DFS(matrix, row, column + 1, value, pathLength + 1);
            int max1 = Math.Max(up, down);
            int left = DFS(matrix, row - 1, column, value, pathLength + 1);
            int right = DFS(matrix, row + 1, column, value, pathLength + 1);
            int max2 = Math.Max(left, right);

            int totalMax = Math.Max(max1, max2) + 1;

            this.longestPathsMemo[row][column] = totalMax;
            matrix[row][column] = value;

            return totalMax;
        }
    }
}
