using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class OrangesRottingSln
    {
        public int OrangesRotting(int[][] grid)
        {
            int time = 0;
            int freshOranges = 0;
            int levelSize;
            int ROWS = grid.Length;
            int COLS = grid[0].Length;

            var directions = new int[4][] {
                new int[2] {  1,  0 },
                new int[2] { -1,  0 },
                new int[2] {  0,  1 },
                new int[2] {  0, -1 },
            };

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid.Length; ++j)
                {
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }
                    if (grid[i][j] == 1)
                    {
                        freshOranges++;
                    }
                }
            }

            while (queue.Count != 0 && freshOranges > 0)
            {
                levelSize = queue.Count;
                time++;
                for (int i = 0; i < levelSize; ++i)
                {
                    int[] currentCoorinate = queue.Dequeue();

                    foreach (int[] direction in directions)
                    {
                        int nextRow = currentCoorinate[0] + direction[0];
                        int nextCol = currentCoorinate[1] + direction[1];

                        if (nextRow < 0 || nextCol < 0 || nextRow >= ROWS || nextCol >= COLS || grid[nextRow][nextCol] != 1)
                            continue;

                        grid[nextRow][nextCol] = 2;
                        freshOranges--;
                        queue.Enqueue(new int[] { nextRow, nextCol });
                    }
                }
            }

            return freshOranges == 0 ? time : -1;
        }
    }
}
