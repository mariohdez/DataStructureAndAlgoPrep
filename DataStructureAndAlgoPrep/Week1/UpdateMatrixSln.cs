using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class UpdateMatrixSln
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            var answer = new int[mat.Length][];
            var visited = new bool[mat.Length][];
            var directions = new int[4][] { new int[2] { 1, 0 }, new int[2] { -1, 0 }, new int[2] { 0, 1 }, new int[2] { 0, -1 } };
            for (int i = 0; i < mat.Length; ++i)
            {
                answer[i] = new int[mat[i].Length];
                visited[i] = new bool[mat[i].Length];
                for (int j = 0; j < mat[0].Length; ++j)
                {
                    answer[i][j] = int.MaxValue;
                }
            }

            var queue = new Queue<int[]>();

            for (int i = 0; i < mat.Length; ++i)
            {
                for (int j = 0; j < mat[0].Length; ++j)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue(new int[2] { i, j });
                        visited[i][j] = true;
                        answer[i][j] = 0;
                    }
                }
            }

            while (queue.Count != 0)
            {
                var curCoordinate = queue.Dequeue();

                foreach (var direction in directions)
                {
                    var newRow = curCoordinate[0] + direction[0];
                    var newCol = curCoordinate[1] + direction[1];
                    if (newRow >= 0 && newCol >= 0 && newRow < mat.Length && newCol < mat[0].Length)
                    {
                        if (answer[newRow][newCol] > answer[curCoordinate[0]][curCoordinate[1]] + 1)
                        {
                            answer[newRow][newCol] = answer[curCoordinate[0]][curCoordinate[1]] + 1;
                            queue.Enqueue(new int[] { newRow, newCol });
                        }
                    }
                }
            }

            return answer;
        }
    }
}
