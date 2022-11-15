using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
	public class LongestPalindromeSln
	{
        public int LongestPalindrome(string s)
        {
            IDictionary<char, int> characterFrequency = new Dictionary<char, int>();
            int longestPalindrome = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                if (characterFrequency.ContainsKey(s[i]))
                {
                    characterFrequency[s[i]] = characterFrequency[s[i]] + 1;
                }
                else
                {
                    characterFrequency.Add(s[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> kvPair in characterFrequency)
            {
                if (kvPair.Value % 2 == 0)
                {
                    longestPalindrome += kvPair.Value;
                }
                else
                {
                    longestPalindrome += ((kvPair.Value / 2) * 2);
                    if (longestPalindrome % 2 == 0)
                    {
                        longestPalindrome = longestPalindrome + 1;
                    }
                }

            }


            return longestPalindrome;
        }
    }
}

