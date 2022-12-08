using System;
using System.Text;
using System.Collections.Generic;
using System.Net;

namespace DataStructureAndAlgoPrep.Week5
{
    public class FindWordsSln
    {
        ISet<string> wordsFound = new HashSet<string>();
        public IList<string> FindWords(char[][] board, string[] words)
        {
            TrieNode root = new TrieNode();
            int rows = board.Length;
            int columns = board[0].Length;
            int index;

            foreach (string word in words)
            {
                InsertWord(root, word);
            }

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < columns; ++c)
                {
                    index = board[r][c] - 'a';

                    if (root.Children[index] != null)
                    {
                        DFS(board, r, c, root, new StringBuilder());
                    }
                }
            }

            return new List<string>(this.wordsFound);
        }

        public void DFS(char[][] board, int row, int column, TrieNode currentTrieNode, StringBuilder currentWord)
        {
            if (currentTrieNode.IsWord)
            {
                this.wordsFound.Add(currentWord.ToString());
            }

            if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length)
            {
                return;
            }

            if (board[row][column] == '*')
            {
                return;
            }

            if (currentTrieNode.Children[board[row][column] - 'a'] == null)
            {
                return;
            }

            currentWord.Append(board[row][column]);
            char temp = board[row][column];
            board[row][column] = '*';

            // explore
            DFS(board, row + 1, column, currentTrieNode.Children[temp - 'a'], currentWord);
            DFS(board, row - 1, column, currentTrieNode.Children[temp - 'a'], currentWord);
            DFS(board, row, column + 1, currentTrieNode.Children[temp - 'a'], currentWord);
            DFS(board, row, column - 1, currentTrieNode.Children[temp - 'a'], currentWord);

            // backtrack
            currentWord.Remove(currentWord.Length - 1, 1);
            board[row][column] = temp;
        }

        public void InsertWord(TrieNode root, string word)
        {
            TrieNode currentNode = root;
            TrieNode nextNode;
            char c;
            int index;

            for (int i = 0; i < word.Length; ++i)
            {
                c = word[i];
                index = c - 'a';

                if (currentNode.Children[index] == null)
                {
                    nextNode = new TrieNode();
                    currentNode.Children[index] = nextNode;
                }
                else
                {
                    nextNode = currentNode.Children[index];
                }

                currentNode = nextNode;
            }

            currentNode.IsWord = true;
        }

        public class TrieNode
        {
            public TrieNode[] Children { get; set; }
            public bool IsWord { get; set; }

            public TrieNode()
            {
                this.Children = new TrieNode[26];
                this.IsWord = false;
            }
        }
    }
}
