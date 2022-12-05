using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week4
{
    public class GroupAnagramsSln
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> groupOfAnagrams = new List<IList<string>>();
            IDictionary<string, IList<string>> anagramCodeToWordsMap = new Dictionary<string, IList<string>>();

            foreach (var word in strs)
            {
                string anagramCode = GetAnagramCode(word);

                if (!anagramCodeToWordsMap.ContainsKey(anagramCode))
                {
                    anagramCodeToWordsMap.Add(anagramCode, new List<string>());
                }

                anagramCodeToWordsMap[anagramCode].Add(word);
            }

            foreach (KeyValuePair<string, IList<string>> kvPair in anagramCodeToWordsMap)
            {
                groupOfAnagrams.Add(kvPair.Value);
            }

            return groupOfAnagrams;
        }

        public string GetAnagramCode(string word)
        {
            int[] charFrequencyMap = new int[26];
            StringBuilder anagramCode = new StringBuilder();

            foreach (char c in word)
            {
                charFrequencyMap[c - 'a']++;
            }

            for (int i = 0; i < 26; ++i)
            {
                char c = (char)('a' + i);

                anagramCode.Append(c + ":" + charFrequencyMap[i] + " ");
            }

            return anagramCode.ToString();
        }
    }
}
