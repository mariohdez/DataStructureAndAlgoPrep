using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class SpiralOrderSln
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> values = new List<int>();
            int left = 0;
            int right = matrix[0].Length - 1;
            int top = 0;
            int bottom = matrix.Length - 1;

            while (left <= right && top <= bottom)
            {
                // go left to right

                int leftPointer = left;

                while (leftPointer <= right)
                {
                    // [r][c]
                    values.Add(matrix[top][leftPointer++]);
                }
                top++;


                // go up to down
                int topPointer = top;

                while (topPointer <= bottom)
                {
                    values.Add(matrix[topPointer++][right]);
                }
                right--;

                if (!(left <= right && top <= bottom))
                {
                    break;
                }


                // go right to left
                int rightPointer = right;

                while (rightPointer >= left)
                {
                    values.Add(matrix[bottom][rightPointer--]);
                }
                bottom--;

                // go down to up
                int bottomPointer = bottom;
                while (bottomPointer >= top)
                {
                    values.Add(matrix[bottomPointer--][left]);
                }
                left++;
            }

            return values;
        }
    }
}
