using System;
namespace DataStructureAndAlgoPrep.Week5
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null) return;
            int N = matrix.Length;
            int left = 0;
            int right = N - 1;
            int top = 0;
            int bottom = N - 1;


            while (left < right && top < bottom)
            {
                for (int i = 0; i < right - left; ++i)
                {
                    int temp = matrix[top][left + i];

                    matrix[top][left + i] = matrix[bottom - i][left];
                    matrix[bottom - i][left] = matrix[bottom][right - i];
                    matrix[bottom][right - i] = matrix[top + i][right];
                    matrix[top + i][right] = temp;
                }

                left++;
                right--;
                top++;
                bottom--;
            }

            return;
        }
    }
}
