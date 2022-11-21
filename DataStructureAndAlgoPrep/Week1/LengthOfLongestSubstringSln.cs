using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class LengthOfLongestSubstringSln
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int longest = 0;
            int len = s.Length;
            Dictionary<char, int> characterToCount = new Dictionary<char, int>();
            int left = 0;
            int right = 0;

            while (left < len)
            {
                char charAtRight = s[right];

                if (!characterToCount.ContainsKey(charAtRight)) characterToCount[charAtRight] = 0;

                characterToCount[charAtRight] += 1;

                while (characterToCount[charAtRight] > 1)
                {
                    char charAtLeft = s[left];
                    characterToCount[charAtLeft] -= 1;
                    left++;
                }
                longest = Math.Max(longest, right - left + 1);
                right++;
            }

            return longest;
        }

        public int LengthOfLongestSubstringBruteForce(string s)
        {
            int longest = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                for (int j = i; j < s.Length; ++j)
                {
                    if (areAllCharsUnique(s.Substring(i, (j - i) + 1)))
                    {
                        longest = Math.Max(longest, (j - i) + 1);
                    }
                }
            }

            return longest;
        }

        public bool areAllCharsUnique(string s)
        {
            var hashSet = new HashSet<char>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (hashSet.Contains(s[i]))
                {
                    return false;
                }

                hashSet.Add(s[i]);
            }

            return true;
        }
    }
}
