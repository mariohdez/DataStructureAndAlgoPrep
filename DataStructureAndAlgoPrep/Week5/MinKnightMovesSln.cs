using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class MinKnightMovesSln
    {
        private int[][] directions = new int[8][]
        {
            new int[2] { -1,   2 },
            new int[2] {  1,   2 },
            new int[2] { -2,   1 },
            new int[2] { -2,  -1 },
            new int[2] { -1,  -2 },
            new int[2] {  1,  -2 },
            new int[2] {  2,   1 },
            new int[2] {  2,  -1 },
        };

        public int MinKnightMoves(int x, int y)
        {
            int moves = 0;
            Queue<(int x, int y)> q = new Queue<(int x, int y)>();
            ISet<(int x, int y)> visited = new HashSet<(int x, int y)>();
            int numberOfNodesInThisLevel = 0;

            visited.Add((0, 0));
            q.Enqueue((0, 0));

            while (q.Count != 0)
            {
                numberOfNodesInThisLevel = q.Count;

                for (int i = 0; i < numberOfNodesInThisLevel; ++i)
                {
                    (int x, int y) position = q.Dequeue();

                    if (position.x == x && position.y == y)
                    {
                        return moves;
                    }

                    foreach (int[] direction in directions)
                    {
                        int newX = position.x + direction[0];
                        int newY = position.y + direction[1];

                        if (visited.Contains((newX, newY)))
                        {
                            continue;
                        }

                        visited.Add((newX, newY));
                        q.Enqueue((newX, newY));
                    }
                }

                moves++;
            }

            return moves;
        }
    }
}
