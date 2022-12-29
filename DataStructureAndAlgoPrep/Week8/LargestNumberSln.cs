using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week8;

public class LargestNumberSln
{
    public string LargestNumber(int[] nums)
    {
        StringBuilder strBuilder = new StringBuilder();
        Array.Sort(nums, new ConcatenateComparer());

        if (nums[0] == 0) return "0";

        for (int i = 0; i < nums.Length; ++i)
        {
            strBuilder.Append(nums[i]);
        }


        return strBuilder.ToString();
    }
}

public class ConcatenateComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        string strA = x.ToString() + y.ToString();
        string strB = y.ToString() + x.ToString();

        return -1 * string.Compare(strA, strB);
    }
}
