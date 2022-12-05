using System;
namespace DataStructureAndAlgoPrep.Week5
{
    public class SetZeroesSln
    {
        private int rows;
        private int cols;

        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null) return;
            this.rows = matrix.Length;
            this.cols = matrix[0].Length;
            int zerothRow = 1;

            for (int r = 0; r < this.rows; ++r)
            {
                for (int c = 0; c < this.cols; ++c)
                {
                    if (matrix[r][c] == 0)
                    {
                        if (r == 0)
                        {
                            zerothRow = 0;
                        }
                        else
                        {
                            matrix[r][0] = 0;
                        }

                        matrix[0][c] = 0;
                    }
                }
            }

            for (int c = 1; c < this.cols; ++c)
            {
                if (matrix[0][c] == 0)
                {
                    SetColumnToZero(matrix, c);
                }
            }

            for (int r = 1; r < this.rows; ++r)
            {
                if (matrix[r][0] == 0)
                {
                    SetRowToZero(matrix, r);
                }
            }

            bool setTopLeftCornerToZero = false;

            if (zerothRow == 0)
            {
                for (int c = 0; c < this.cols; ++c)
                {
                    if (c == 0 && matrix[0][c] != 0)
                    {
                        setTopLeftCornerToZero = true;
                        continue;
                    }
                    else
                    {
                        matrix[0][c] = 0;
                    }
                }
            }

            if (matrix[0][0] == 0)
            {
                SetColumnToZero(matrix, 0);
            }

            if (setTopLeftCornerToZero)
            {
                matrix[0][0] = 0;
            }
        }

        public void SetRowToZero(int[][] matrix, int r)
        {
            for (int c = 1; c < this.cols; ++c)
            {
                matrix[r][c] = 0;
            }
        }

        public void SetColumnToZero(int[][] matrix, int c)
        {
            for (int r = 1; r < this.rows; ++r)
            {
                matrix[r][c] = 0;
            }
        }
    }
}
