namespace LeetCodeExcercises
{
    public static class SurroundedRegions
    {
        public static void Solve(char[][] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O' && i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        Capture(i, j, rows, cols, board);
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                    else if (board[i][j] == 'T')
                    {
                        board[i][j] = 'O';
                    }
                }
            }
        }

        public static void Capture(int r, int c, int rows, int cols, char[][] board)
        {
            if (r < 0 || c < 0 || r == rows || c == cols || board[r][c] != 'O') return;

            board[r][c] = 'T';

            Capture(r + 1, c, rows, cols, board);
            Capture(r - 1, c, rows, cols, board);
            Capture(r, c + 1, rows, cols, board);
            Capture(r, c - 1, rows, cols, board);
        }
    }
}
