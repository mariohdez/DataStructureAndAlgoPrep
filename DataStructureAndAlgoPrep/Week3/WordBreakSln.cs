using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class WordBreakSln
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];
            dp[s.Length] = true;

            for (int i = s.Length - 1; i >= 0; --i)
            {
                for (int j = 0; j < wordDict.Count; ++j)
                {
                    var word = wordDict[j];

                    if (i + word.Length <= s.Length && string.Equals(s.Substring(i, word.Length), word))
                    {
                        dp[i] = dp[i + word.Length];
                    }

                    if (dp[i])
                    {
                        break;
                    }
                }
            }

            return dp[0];
        }
    }
}
