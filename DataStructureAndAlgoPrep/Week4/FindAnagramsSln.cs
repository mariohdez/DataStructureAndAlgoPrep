using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class FindAnagramsSln
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IDictionary<char, int> pCharFrequencyMap = new Dictionary<char, int>();
            IDictionary<char, int> sCharFrequencyMap = new Dictionary<char, int>();
            IList<int> answer = new List<int>();

            if (p.Length > s.Length) return answer;

            for (int i = 0; i < p.Length; ++i)
            {
                if (!pCharFrequencyMap.ContainsKey(p[i]))
                {
                    pCharFrequencyMap.Add(p[i], 0);
                }

                pCharFrequencyMap[p[i]] += 1;

                if (!sCharFrequencyMap.ContainsKey(s[i]))
                {
                    sCharFrequencyMap.Add(s[i], 0);
                }

                sCharFrequencyMap[s[i]] += 1;
            }

            if (areSameFreq(pCharFrequencyMap, sCharFrequencyMap))
            {
                answer.Add(0);
            }

            int left = 0;

            for (int right = p.Length; right < s.Length; ++right)
            {
                if (!sCharFrequencyMap.ContainsKey(s[right]))
                {
                    sCharFrequencyMap.Add(s[right], 0);
                }

                sCharFrequencyMap[s[right]] += 1;
                sCharFrequencyMap[s[left]] -= 1;

                left++;

                if (areSameFreq(pCharFrequencyMap, sCharFrequencyMap))
                {
                    answer.Add(left);
                }
            }

            return answer;
        }

        public bool areSameFreq(IDictionary<char, int> pCharFreqMap, IDictionary<char, int> sCharFreqMap)
        {
            foreach (var kvPair in pCharFreqMap)
            {
                if (!sCharFreqMap.ContainsKey(kvPair.Key))
                {
                    return false;
                }

                if (sCharFreqMap[kvPair.Key] != kvPair.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
