using System;
namespace DataStructureAndAlgoPrep.Week2
{
    public class NumberOfIsandsSolution
    {
        private int[][] directions = new int[4][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

        public int NumIslands(char[][] grid)
        {
            int numberOfIslands = 0;
            int numberOfRows = grid.Length;
            int numberOfColumns = grid[0].Length;

            for (int i = 0; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid[0].Length; ++j)
                {
                    if (grid[i][j] == '1')
                    {
                        VisitGrid(grid, i, j, numberOfRows, numberOfColumns);
                        numberOfIslands++;
                    }
                }
            }

            return numberOfIslands;
        }

        public void VisitGrid(char[][] grid, int row, int col, int rowBoundry, int colBoundry)
        {
            if (row < 0 || row >= rowBoundry || col < 0 || col >= colBoundry) return; // protect against index out of bounds exception.
            if (grid[row][col] == '#') return; // already visited.
            if (grid[row][col] == '0') return; // not a valid value to visit.

            grid[row][col] = '#'; // visit node.

            foreach (int[] direction in directions)
            {
                VisitGrid(grid, row + direction[0], col + direction[1], rowBoundry, colBoundry);
            }
        }
    }
}
