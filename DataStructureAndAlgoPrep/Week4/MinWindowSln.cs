using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class MinWindowSln
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(t)) return "";
            IDictionary<char, int> window = new Dictionary<char, int>();
            string result = string.Empty;
            int minimumLength = int.MaxValue;
            int have = 0;
            int need = 0;
            IDictionary<char, int> tCharFrequencyMap = new Dictionary<char, int>();

            foreach (char c in t)
            {
                if (!tCharFrequencyMap.ContainsKey(c))
                {
                    tCharFrequencyMap.Add(c, 0);
                }

                tCharFrequencyMap[c] += 1;
            }

            need = tCharFrequencyMap.Count;
            int left = 0;
            for (int right = 0; right < s.Length; ++right)
            {
                char c = s[right];
                if (!window.ContainsKey(c))
                {
                    window.Add(c, 0);
                }
                window[c] += 1;

                if (tCharFrequencyMap.ContainsKey(c) && window[c] == tCharFrequencyMap[c])
                {
                    have++;
                }

                while (have == need)
                {
                    if (right - left + 1 < minimumLength)
                    {
                        result = s.Substring(left, right - left + 1);
                        minimumLength = right - left + 1;
                    }
                    window[s[left]] -= 1;

                    if (tCharFrequencyMap.ContainsKey(s[left]) && window[s[left]] < tCharFrequencyMap[s[left]])
                    {
                        have--;
                    }

                    left++;
                }
            }

            return result;
        }
    }
}
