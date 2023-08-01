namespace LeetCodeExcercises
{
    public static class WordSearch
    {
        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            bool[,] used = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Dfs(board, i, j, 0, word, used, rows, cols)) return true;
                }
            }
            return false;
        }

        public static bool Dfs(char[][] board, int r, int c, int i, string word, bool[,] used, int rows, int cols)
        {
            bool res;
            if (i == word.Length)
            {
                return true;
            }
            if (r < 0 || c < 0 || r >= rows || c >= cols || word[i] != board[r][c] || used[r, c] == true)
            {
                return false;
            }
            used[r, c] = true;
            res = (Dfs(board, r + 1, c, i + 1, word, used, rows, cols) ||
                    Dfs(board, r - 1, c, i + 1, word, used, rows, cols) ||
                    Dfs(board, r, c + 1, i + 1, word, used, rows, cols) ||
                    Dfs(board, r, c - 1, i + 1, word, used, rows, cols));

            used[r, c] = false;
            return res;
        }
    }
}
