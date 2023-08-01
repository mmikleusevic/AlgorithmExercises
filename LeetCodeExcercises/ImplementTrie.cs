namespace LeetCodeExcercises
{
    public class ImplementTrie
    {
        private TrieNode root;

        public ImplementTrie()
        {
            root = new();
        }

        public void Insert(string word)
        {
            TrieNode cur = root;

            foreach (char c in word)
            {
                if (cur.Children[c - 'a'] == null)
                {
                    cur.Children[c - 'a'] = new TrieNode();
                }
                cur = cur.Children[c - 'a'];
            }
            cur.IsEnd = true;
        }

        public bool Search(string word)
        {
            TrieNode cur = root;

            foreach (char c in word)
            {
                if (cur.Children[c - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    cur = cur.Children[c - 'a'];
                }
            }
            return cur.IsEnd;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode cur = root;

            foreach (char c in prefix)
            {
                if (cur.Children[c - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    cur = cur.Children[c - 'a'];
                }
            }
            return true;
        }
    }

    public class TrieNode
    {
        public TrieNode[] Children { get; } = new TrieNode[26];

        public bool IsEnd { get; set; } = false;
    }
}
