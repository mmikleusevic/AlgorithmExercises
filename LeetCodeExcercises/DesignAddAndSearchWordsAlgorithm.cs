namespace LeetCodeExcercises
{
    public class TrieNodeBook
    {
        public Dictionary<char, TrieNodeBook> Children = new Dictionary<char, TrieNodeBook>();
        public bool Finished = false;
    }

    public class DesignAddAndSearchWordsAlgorithm
    {
        private readonly TrieNodeBook root;
        public DesignAddAndSearchWordsAlgorithm()
        {
            root = new();
        }

        public void AddWord(string word)
        {
            TrieNodeBook cur = root;

            foreach (char c in word)
            {
                if (!cur.Children.ContainsKey(c))
                {
                    cur.Children.Add(c, new TrieNodeBook());
                }
                cur = cur.Children[c];
            }

            cur.Finished = true;
        }

        public bool Search(string word)
        {
            return Search(word, root);
        }

        public bool Search(string word, TrieNodeBook startPoint)
        {
            TrieNodeBook cur = startPoint;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (c == '.')
                {
                    foreach (char key in cur.Children.Keys)
                    {
                        if (Search(word.Substring(i + 1), cur.Children[key]))
                            return true;
                    }
                    return false;
                }
                else if (cur.Children.ContainsKey(c))
                {
                    cur = cur.Children[c];
                }
                else
                {
                    return false;
                }
            }
            return cur.Finished;
        }
    }
}
