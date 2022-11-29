using System;
namespace DataStructureAndAlgoPrep.Week3
{
    public class LongestPalindromicSubstringSln
    {
        public string LongestPalindrome(string s)
        {
            string result = string.Empty;
            int lengthOfResult = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                int left = i;
                int right = i;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if ((right - left + 1) > lengthOfResult)
                    {
                        result = s.Substring(left, right - left + 1);
                        lengthOfResult = result.Length;
                    }

                    left--;
                    right++;
                }

                left = i;
                right = i + 1;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if ((right - left + 1) > lengthOfResult)
                    {
                        result = s.Substring(left, right - left + 1);
                        lengthOfResult = result.Length;
                    }

                    left--;
                    right++;
                }
            }

            return result;
        }
    }
}
