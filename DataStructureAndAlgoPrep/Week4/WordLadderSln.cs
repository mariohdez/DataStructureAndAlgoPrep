using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataStructureAndAlgoPrep.Week4
{
    public class WordLadderSln
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            ISet<string> wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord)) return 0;

            wordSet.Add((beginWord));
            IDictionary<string, IList<string>> patternToNeighborsMap = new Dictionary<string, IList<string>>();
            ISet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            int level = 0;

            foreach (string word in wordSet)
            {
                for (int i = 0; i < word.Length; ++i)
                {
                    string pattern = GetPatternFromWord(word, i);

                    if (!patternToNeighborsMap.ContainsKey(pattern))
                    {
                        patternToNeighborsMap.Add(pattern, new List<string>());
                    }

                    patternToNeighborsMap[pattern].Add(word);
                }
            }

            visited.Add(beginWord);
            queue.Enqueue(beginWord);

            while (queue.Count != 0)
            {
                int numberOfWordsInThisLevel = queue.Count;

                for (int i = 0; i < numberOfWordsInThisLevel; ++i)
                {
                    string currentWord = queue.Dequeue();

                    if (string.Equals(currentWord, endWord))
                    {
                        return level + 1;
                    }

                    for (int j = 0; j < currentWord.Length; ++j)
                    {
                        string pattern = GetPatternFromWord(currentWord, j);

                        foreach (string neighbor in patternToNeighborsMap[pattern])
                        {
                            if (string.Equals(currentWord, neighbor)) continue;
                            if (!visited.Contains(neighbor))
                            {
                                visited.Add(neighbor);
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                }

                level++;
            }

            return level;
        }

        public string GetPatternFromWord(string word, int i)
        {
            int leftPoritionStart = 0;
            int leftPoritionEnd = i - 1;
            int rightPoritionStart = i + 1;
            int rightPortionEnd = word.Length - 1;

            string leftPorition = word.Substring(leftPoritionStart, leftPoritionEnd - leftPoritionStart + 1);
            string rightPorition = word.Substring(rightPoritionStart, rightPortionEnd - rightPoritionStart + 1);

            return leftPorition + "*" + rightPorition;
        }

        public int LadderLengthTLE(string beginWord, string endWord, IList<string> wordList)
        {
            ISet<string> wordSet = new HashSet<string>(wordList);
            IDictionary<string, ISet<string>> adjacencyGraph = new Dictionary<string, ISet<string>>();
            Queue<(string, int)> queue = new Queue<(string, int)>();
            ISet<string> visited = new HashSet<string>();

            if (!wordSet.Contains(endWord)) return 0;

            wordSet.Add((beginWord));

            foreach (string word in wordSet)
            {
                for (int i = 0; i < word.Length; ++i)
                {
                    var leftPortionStart = 0;
                    var leftPoritionEnd = i - 1;
                    var rightPoritionStart = i + 1;
                    var rightPoritionEnd = word.Length - 1;
                    var leftPortion = word.Substring(leftPortionStart, leftPoritionEnd - leftPortionStart + 1);
                    var rightPorition = word.Substring(rightPoritionStart, rightPoritionEnd - rightPoritionStart + 1);

                    var wordWithoutOneChar = leftPortion + rightPorition;
                    if (!adjacencyGraph.ContainsKey(word))
                    {
                        adjacencyGraph.Add(word, new HashSet<string>());
                    }

                    foreach (string otherWord in wordSet)
                    {
                        if (otherWord.Equals(word)) continue;

                        if (!adjacencyGraph.ContainsKey(otherWord))
                        {
                            adjacencyGraph.Add(otherWord, new HashSet<string>());
                        }

                        var otherWordLeftPortionStart = 0;
                        var otherWordLeftPoritionEnd = i - 1;
                        var otherWordRightPoritionStart = i + 1;
                        var otherWordRightPoritionEnd = otherWord.Length - 1;
                        var otherWordLeftPortion = otherWord.Substring(otherWordLeftPortionStart, otherWordLeftPoritionEnd - otherWordLeftPortionStart + 1);
                        var otherWordRightPorition = otherWord.Substring(otherWordRightPoritionStart, otherWordRightPoritionEnd - otherWordRightPoritionStart + 1);
                        var otherWordWithoutOneChar = otherWordLeftPortion + otherWordRightPorition;

                        if (wordWithoutOneChar.Equals(otherWordWithoutOneChar))
                        {
                            adjacencyGraph[word].Add(otherWord);
                            adjacencyGraph[otherWord].Add(word);
                        }
                    }
                }
            }

            queue.Enqueue((beginWord, 0));
            visited.Add(beginWord);

            while (queue.Count != 0)
            {
                (string, int) tuple = queue.Dequeue();
                string currentWord = tuple.Item1;
                int currentLevel = tuple.Item2;

                if (string.Equals(currentWord, endWord))
                {
                    return currentLevel + 1;
                }

                foreach (var neighborWord in adjacencyGraph[currentWord])
                {
                    if (!visited.Contains(neighborWord))
                    {
                        visited.Add(neighborWord);
                        queue.Enqueue((neighborWord, currentLevel + 1));
                    }
                }
            }

            return 0;
        }
    }
}
