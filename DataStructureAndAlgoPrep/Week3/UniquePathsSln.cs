using System;
namespace DataStructureAndAlgoPrep.Week3
{
    public class UniquePathsSln
    {
        private int paths = 0;
        public int UniquePaths(int m, int n)
        {

            int[][] dp = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                dp[i] = new int[n];
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    dp[i][j] = 1;
                }
            }

            for (int col = 1; col < m; ++col)
            {
                for (int row = 1; row < n; ++row)
                {
                    dp[col][row] = dp[col - 1][row] + dp[col][row - 1];
                }
            }

            return dp[m - 1][n-1];
        }

        public void UniquePathsDFS(int currentRow, int currentColumn, int numberOfRows, int numberOfCols, int targetRow, int targetCol)
        {
            if (currentRow < 0 || currentRow >= numberOfRows || currentColumn < 0 || currentColumn >= numberOfCols)
            {
                return;
            }

            if (currentRow == targetRow && currentColumn == targetCol)
            {
                this.paths++;
                return;
            }

            UniquePathsDFS(
                currentRow: currentRow + 1,
                currentColumn: currentColumn,
                numberOfRows: numberOfRows,
                numberOfCols: numberOfCols,
                targetRow: targetRow,
                targetCol: targetCol);

            UniquePathsDFS(
                currentRow: currentRow,
                currentColumn: currentColumn + 1,
                numberOfRows: numberOfRows,
                numberOfCols: numberOfCols,
                targetRow: targetRow,
                targetCol: targetCol);
        }
    }
}
