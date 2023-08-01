namespace LeetCodeExcercises
{
    public static class WordSearchII
    {
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            TrieNodeWS root = new TrieNodeWS();

            foreach (string w in words)
            {
                root.AddWord(root, w);
            }
            int rows = board.Length;
            int cols = board[0].Length;
            HashSet<string> res = new();
            bool[,] visited = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    DFS(i, j, rows, cols, root, "", board, visited, res);
                }
            }
            return res.ToList();
        }

        public static void DFS(int r, int c, int rows, int cols, TrieNodeWS node, string word, char[][] board, bool[,] visited, HashSet<string> res)
        {
            if (r < 0 || c < 0 || r >= rows || c >= cols || visited[r, c] == true || node.Children[board[r][c] - 'a'] == null) return;

            visited[r, c] = true;
            node = node.Children[board[r][c] - 'a'];
            word += board[r][c];
            if (node.IsWord)
            {
                res.Add(word);
            }

            DFS(r + 1, c, rows, cols, node, word, board, visited, res);
            DFS(r - 1, c, rows, cols, node, word, board, visited, res);
            DFS(r, c + 1, rows, cols, node, word, board, visited, res);
            DFS(r, c - 1, rows, cols, node, word, board, visited, res);

            visited[r, c] = false;
        }
    }

    public class TrieNodeWS
    {
        public TrieNodeWS[] Children { get; } = new TrieNodeWS[26];
        public bool IsWord { get; set; }

        public void AddWord(TrieNodeWS root, string word)
        {
            TrieNodeWS cur = root;
            foreach (char c in word)
            {
                if (cur.Children[c - 'a'] == null)
                {
                    cur.Children[c - 'a'] = new TrieNodeWS();
                }
                cur = cur.Children[c - 'a'];
            }
            cur.IsWord = true;
        }
    }
}
