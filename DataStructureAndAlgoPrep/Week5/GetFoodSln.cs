using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week5
{
    public class GetFoodSln
    {
        private int Columns = 0;
        private int Rows = 0;
        private const int NotPossible = -1;

        private int[][] Directions = new int[4][]
        {
            new int[2] { 1,  0  },
            new int[2] { -1, 0  },
            new int[2] { 0,  1  },
            new int[2] { 0,  -1 },
        };

        public int GetFood(char[][] grid)
        {
            this.Rows = grid.Length;
            this.Columns = grid[0].Length;

            (int row, int column) startingCoordinate = FindStartingPoint(grid);

            if (startingCoordinate.row == -1 && startingCoordinate.column == -1)
            {
                return NotPossible;
            }

            Queue<(int row, int column, int level)> queue = new Queue<(int row, int column, int level)>();
            ISet<(int row, int column)> visited = new HashSet<(int row, int column)>();

            queue.Enqueue((startingCoordinate.row, startingCoordinate.column, 0));
            visited.Add((startingCoordinate.row, startingCoordinate.column));
            int level = 0;

            while (queue.Count != 0)
            {
                int numberOfItemsInThisLevel = queue.Count;

                for (int i = 0; i < numberOfItemsInThisLevel; ++i)
                {
                    (int row, int column, int level) currentCell = queue.Dequeue();

                    if (grid[currentCell.row][currentCell.column] == '#')
                    {
                        return currentCell.level;
                    }

                    foreach (int[] direction in this.Directions)
                    {
                        int newRow = currentCell.row + direction[0];
                        int newCol = currentCell.column + direction[1];

                        if (newRow < 0 || newRow >= this.Rows || newCol < 0 || newCol >= this.Columns)
                        {
                            continue;
                        }

                        if (grid[newRow][newCol] == 'X')
                        {
                            continue;
                        }

                        if (visited.Contains((newRow, newCol)))
                        {
                            continue;
                        }
                        visited.Add((newRow, newCol));
                        queue.Enqueue((newRow, newCol, currentCell.level + 1));
                    }
                }

                level++;
            }

            return NotPossible;
        }

        private (int, int) FindStartingPoint(char[][] grid)
        {
            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Columns; ++c)
                {
                    if (grid[r][c] == '*')
                    {
                        return (r, c);
                    }
                }
            }

            return (-1, -1);
        }
    }
}
