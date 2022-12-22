
namespace DataStructureAndAlgoPrep.Week7;

public class WordDictionary
{
    private readonly TrieNode root;
    public WordDictionary()
    {
        root = new TrieNode();
    }

    public void AddWord(string word)
    {
        TrieNode currentNode = this.root;

        for (int i = 0; i < word.Length; ++i)
        {
            char c = word[i];

            TrieNode nextNode = null;

            if (currentNode.Children[c - 'a'] == null)
            {
                nextNode = new TrieNode();
                currentNode.Children[c - 'a'] = nextNode;
            }
            else
            {
                nextNode = currentNode.Children[c - 'a'];
            }

            currentNode = nextNode;
        }

        currentNode.IsWord = true;
    }

    public bool Search(string word)
    {
        return SearchBackTracking(word, 0, this.root);
    }

    public bool SearchBackTracking(string word, int currentIndex, TrieNode currentNode)
    {
        if (currentNode == null)
        {
            return false;
        }

        if (currentIndex >= word.Length && !currentNode.IsWord)
        {
            return false;
        }

        if (currentIndex >= word.Length && currentNode.IsWord)
        {
            return true;
        }

        char c = word[currentIndex];
        var res = false;

        if (char.Equals(c, '.'))
        {
            for (int i = 0; i < 26; ++i)
            {
                if (currentNode.Children[i] != null)
                {
                    res = res || SearchBackTracking(word, currentIndex + 1, currentNode.Children[i]);
                }
            }
            if (!res)
            {
                return false;
            }
        }
        else
        {
            if (currentNode.Children[c - 'a'] == null)
            {
                return false;
            }

            res = SearchBackTracking(word, currentIndex + 1, currentNode.Children[c - 'a']);
        }

        return res;
    }
}

public class TrieNode
{
    public TrieNode[] Children { get; set; } = new TrieNode[26];
    public bool IsWord { get; set; }
}
