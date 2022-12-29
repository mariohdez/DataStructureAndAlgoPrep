using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week8;

public class LongestRepeatingCharacterReplacementSln
{
    public int CharacterReplacement(string s, int k)
    {
        IDictionary<char, int> characterToCountMap = new Dictionary<char, int>();
        int left = 0;
        int right = 0;
        int maxLen = int.MinValue;

        while (right < s.Length)
        {
            if (!characterToCountMap.ContainsKey(s[right]))
            {
                characterToCountMap.Add(s[right], 0);
            }

            characterToCountMap[s[right]]++;

            var res = GetMostFrequentCharacter(characterToCountMap);
            int windowSize = right - left + 1;

            if (windowSize - res.Value <= k)
            {
                if (windowSize > maxLen)
                {
                    maxLen = windowSize;
                }
            }
            else
            {
                characterToCountMap[s[left]]--;
                left++;
            }

            right++;
        }

        return maxLen;
    }

    public KeyValuePair<char, int> GetMostFrequentCharacter(IDictionary<char, int> characterToCountMap)
    {
        int maxCount = int.MinValue;
        KeyValuePair<char, int> kvPair = new KeyValuePair<char, int>('A', 0);
        foreach (KeyValuePair<char, int> keyValue in characterToCountMap)
        {
            if (keyValue.Value > maxCount)
            {
                maxCount = keyValue.Value;
                kvPair = keyValue;
            }
        }

        return kvPair;
    }
}