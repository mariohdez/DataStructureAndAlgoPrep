using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week2
{
    public class Trie
    {
        private readonly TrieNode Root;

        public Trie()
        {
            this.Root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode currentNode = this.Root;

            for (int i = 0; i < word.Length; ++i)
            {
                TrieNode nextNode = null;
                if (!currentNode.Children.ContainsKey(word[i]))
                {
                    nextNode = new TrieNode();
                    currentNode.Children[word[i]] = nextNode;
                }

                nextNode = currentNode.Children[word[i]];
                currentNode = nextNode;
            }

            currentNode.EndOfWord = true;
        }

        public TrieNode SearchPrefix(string word)
        {
            TrieNode currentNode = this.Root;

            for (int i = 0; i < word.Length; ++i)
            {
                if (!currentNode.Children.ContainsKey(word[i]))
                {
                    return null;
                }
                currentNode = currentNode.Children[word[i]];
            }

            return currentNode;
        }

        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);

            return node != null && node.EndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchPrefix(prefix);

            return node != null;
        }
    }

    public class TrieNode
    {
        public bool EndOfWord { get; set; }

        public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();
    }
}
