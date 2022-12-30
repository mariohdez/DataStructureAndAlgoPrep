using System;
using System.Collections.Generic;

public class PalindromePairsSln
{
    public IList<string> AllValidPrefixes(string word)
    {
        IList<string> validPrefixes = new List<string>();

        for (int i = 0; i < word.Length; ++i)
        {
            if (IsPanindromeBetween(word, i, word.Length - 1))
            {
                validPrefixes.Add(word.Substring(0, i));
            }
        }

        return validPrefixes;
    }

    public IList<string> AllValidSuffixes(string word)
    {
        IList<string> validSuffixes = new List<string>();

        for (int i = 0; i < word.Length; ++i)
        {
            if (IsPanindromeBetween(word, 0, i))
            {
                validSuffixes.Add(word.Substring(i + 1));
            }
        }

        return validSuffixes;
    }

    public bool IsPanindromeBetween(string word, int start, int end)
    {
        while (start < end)
        {
            if (!char.Equals(word[start], word[end]))
            {
                return false;
            }

            end--;
            start++;
        }

        return true;
    }

    public IList<IList<int>> PalindromePairs(string[] words)
    {
        IDictionary<string, int> wordToIndexMap = new Dictionary<string, int>();
        IList<IList<int>> palindromePairs = new List<IList<int>>();

        for (int i = 0; i < words.Length; ++i)
        {
            wordToIndexMap.Add(words[i], i);
        }

        foreach (string word in words)
        {
            // Case 1
            int currentWordIndex = wordToIndexMap[word];
            string reversedWord = Reverse(word);

            if (wordToIndexMap.ContainsKey(reversedWord) && wordToIndexMap[reversedWord] != currentWordIndex)
            {
                palindromePairs.Add(new List<int> { currentWordIndex, wordToIndexMap[reversedWord] });
            }

            // Case 2
            IList<string> validSuffixes = AllValidSuffixes(word);

            foreach (string suffix in validSuffixes)
            {
                string reversedSuffix = Reverse(suffix);
                if (wordToIndexMap.ContainsKey(reversedSuffix))
                {
                    palindromePairs.Add(new List<int> { wordToIndexMap[reversedSuffix], currentWordIndex, });
                }
            }

            // Case 3
            IList<string> validPrefixes = AllValidPrefixes(word);
            foreach (string prefix in validPrefixes)
            {
                string reversedPrefix = Reverse(prefix);

                if (wordToIndexMap.ContainsKey(reversedPrefix))
                {
                    palindromePairs.Add(new List<int> { currentWordIndex, wordToIndexMap[reversedPrefix], });
                }
            }
        }

        return palindromePairs;
    }

    public string Reverse(string word)
    {
        char[] wordCharArray = word.ToCharArray();
        Array.Reverse(wordCharArray);
        return new String(wordCharArray); ;
    }
}
