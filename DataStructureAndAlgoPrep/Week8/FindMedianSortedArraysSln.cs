using System;

namespace DataStructureAndAlgoPrep.Week8;

public class FindMedianSortedArraysSln
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] a = nums1;
        int[] b = nums2;
        if (nums2.Length < nums1.Length)
        {
            a = nums2;
            b = nums1;
        }

        int left = 0;
        int right = b.Length - 1;
        int half = (a.Length + b.Length) / 2;

        while (true)
        {
            int middleA = (left + right) / 2;
            int middleB = half - middleA - 2;

            int aLeft = middleA < 0 ? int.MinValue : a[middleA];
            int aRight = middleA + 1 >= a.Length ? int.MaxValue : a[middleA + 1];
            int bLeft = middleB < 0 ? int.MinValue : b[middleB];
            int bRight = middleB + 1 >= b.Length ? int.MaxValue : b[middleB + 1];

            if (aLeft <= bRight && bLeft <= aRight)
            {
                if (((a.Length+b.Length) % 2)==0)
                {
                    return ((double)Math.Max(aLeft, bLeft) + (double)Math.Max(aRight, bRight)) / 2.0;
                }
                else
                {
                    return Math.Min(aRight, bRight);
                }
            }
            else if (aLeft > bRight)
            {
                right = middleA - 1;
            }
            else
            {
                left = middleA + 1;
            }
        }
    }
}