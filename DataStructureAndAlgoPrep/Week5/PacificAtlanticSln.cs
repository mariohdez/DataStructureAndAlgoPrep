using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class PacificAtlanticSln
    {
        private int Rows;
        private int Columns;
        private const int PACIFIC = 0;
        private const int ATLANTIC = 1;

        private readonly int[][] Directions = new int[4][]
        {
            new int[] {  1,  0 },
            new int[] { -1,  0 },
            new int[] {  0,  1 },
            new int[] {  0, -1 },
        };

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            this.Rows = heights.Length;
            this.Columns = heights[0].Length;

            List<IList<int>> answer = new List<IList<int>>();

            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Columns; ++c)
                {
                    bool hitPacificOcean = DoesCellHitOcean(
                        heights: heights,
                        row: r,
                        column: c,
                        ocean: PACIFIC,
                        previousHeight: heights[r][c],
                        visited: new HashSet<(int, int)>());

                    bool hitAtlanticOcean = DoesCellHitOcean(
                        heights: heights,
                        row: r,
                        column: c,
                        ocean: ATLANTIC,
                        previousHeight: heights[r][c],
                        visited: new HashSet<(int, int)>());

                    if (hitPacificOcean && hitAtlanticOcean)
                    {
                        answer.Add(new List<int> { r, c });
                    }
                }
            }

            return answer;
        }

        public bool DoesCellHitOcean(int[][] heights, int row, int column, int ocean, int previousHeight, ISet<(int, int)> visited)
        {
            if (row < 0 || row >= this.Rows || column < 0 || column >= this.Columns || visited.Contains((row, column)))
            {
                return false;
            }

            if (heights[row][column] > previousHeight)
            {
                return false;
            }

            if (ocean == PACIFIC)
            {
                bool isOnLeftEdge = column == 0;
                bool isOnTopEdge = row == 0;

                if (isOnLeftEdge || isOnTopEdge) return true;
            }
            else
            {
                bool isOnRightEdge = column == this.Columns - 1;
                bool isOnBottomEdge = row == this.Rows - 1;

                if (isOnRightEdge || isOnBottomEdge) return true;
            }

            visited.Add((row, column));

            foreach (int[] direction in this.Directions)
            {
                if (DoesCellHitOcean(heights: heights, row: row + direction[0], column: column + direction[1], ocean: ocean, previousHeight: heights[row][column], visited: visited))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
