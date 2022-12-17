using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class TopKFrequentSln
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        IDictionary<string, int> wordFrequencyMap = new Dictionary<string, int>();
        PriorityQueue<string, (string word, int frequency)> maxHeap = new PriorityQueue<string, (string word, int frequency)>(new WordFrequencyComparer());
        IList<string> topKWords = new List<string>();

        foreach (string word in words)
        {
            if (!wordFrequencyMap.ContainsKey(word))
            {
                wordFrequencyMap.Add(word, 0);
            }

            wordFrequencyMap[word]++;
        }

        foreach (KeyValuePair<string, int> keyValue in wordFrequencyMap)
        {
            maxHeap.Enqueue(keyValue.Key, (keyValue.Key, keyValue.Value));
        }

        for (int i = 0; i < k; ++i)
        {
            topKWords.Add(maxHeap.Dequeue());
        }

        return topKWords;
    }

    public class WordFrequencyComparer : IComparer<(string word, int frequency)>
    {
        public int Compare((string word, int frequency) a, (string word, int frequency) b)
        {
            int frequencyDifference = b.frequency - a.frequency;
            if (frequencyDifference == 0)
            {
                return string.Compare(a.word, b.word);
            }

            return frequencyDifference;
        }
    }
}
