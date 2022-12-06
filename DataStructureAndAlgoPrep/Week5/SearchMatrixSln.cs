using System;
namespace DataStructureAndAlgoPrep.Week5
{
    public class SearchMatrixSln
    {
        private int Rows;
        private int Cols;

        public bool SearchMatrix(int[][] matrix, int target)
        {
            this.Rows = matrix.Length;
            this.Cols = matrix[0].Length;

            int topRow = 0;
            int bottomRow = this.Rows - 1;
            int midRow = 0;

            while (topRow <= bottomRow)
            {
                midRow = ((bottomRow - topRow) / 2) + topRow;

                int leftValue = matrix[midRow][0];
                int rightValue = matrix[midRow][this.Cols - 1];

                if (leftValue <= target && target <= rightValue)
                {
                    break;
                }
                else if (target < leftValue)
                {
                    bottomRow = midRow - 1;
                }
                else
                {
                    topRow = midRow + 1;
                }
            }

            return BinarySearch(matrix, midRow, target);
        }

        public bool BinarySearch(int[][] matrix, int row, int target)
        {
            int left = 0;
            int right = this.Cols - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = ((right - left) / 2) + left;
                if (matrix[row][mid] == target)
                {
                    return true;
                }
                else if (target < matrix[row][mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
