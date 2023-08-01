namespace LeetCodeExcercises
{
    public static class GameOfLife
    {
        public static void GameOfLifeMethod(int[][] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int nei = CountNeighbors(i, j, rows, cols, board);
                    if (board[i][j] == 1)
                    {
                        if (nei == 2 || nei == 3)
                        {
                            board[i][j] = 3;
                        }
                    }
                    else if (nei == 3)
                    {
                        board[i][j] = 2;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 1)
                    {
                        board[i][j] = 0;
                    }
                    else if (board[i][j] == 2 || board[i][j] == 3)
                    {
                        board[i][j] = 1;
                    }
                }
            }
        }

        public static int CountNeighbors(int i, int j, int rows, int cols, int[][] board)
        {
            int nei = 0;
            int r = i;
            int c = j;
            for (i = r - 1; i <= r + 1; i++)
            {
                for (j = c - 1; j <= c + 1; j++)
                {
                    if (i == r && j == c || i < 0 || j < 0 || i == rows || j == cols) continue;
                    if (board[i][j] == 1 || board[i][j] == 3)
                    {
                        nei += 1;
                    }
                }
            }
            return nei;
        }


        // moj kod, više memorije
        //public static void GameOfLifeMethod(int[][] board)
        //{
        //    int rows = board.Length;
        //    int cols = board[0].Length;
        //    int[][] cBoard = new int[rows][];

        //    for(int i = 0; i < rows; i++)
        //    {
        //        int[] array = new int[board[i].Length];
        //        for(int j = 0; j < cols; j++)
        //        {
        //            array[j] = board[i][j];
        //        }
        //        cBoard[i] = array;
        //    }

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            int val = DFS(cBoard, rows, cols, i, j, false);
        //            if (board[i][j] == 1 && val < 2)
        //            {
        //                board[i][j] = 0;
        //            }
        //            else if (board[i][j] == 1 && val <= 3 && val > 1)
        //            {
        //                board[i][j] = 1;
        //            }
        //            else if (board[i][j] == 1 && val > 3)
        //            {
        //                board[i][j] = 0;
        //            }
        //            else if (board[i][j] == 0 && val == 3)
        //            {
        //                board[i][j] = 1;
        //            }
        //        }
        //    }
        //}

        //public static int DFS(int[][] board, int rows, int cols, int r, int c, bool visiting)
        //{
        //    if (r < 0 || c < 0 || r >= rows || c >= cols)
        //    {
        //        return 0;
        //    }
        //    int val =  board[r][c];
        //    if (!visiting)
        //    {
        //        val = DFS(board, rows, cols, r + 1, c, true) +
        //              DFS(board, rows, cols, r - 1, c, true) +
        //              DFS(board, rows, cols, r + 1, c + 1, true) +
        //              DFS(board, rows, cols, r, c + 1, true) +
        //              DFS(board, rows, cols, r, c - 1, true) +
        //              DFS(board, rows, cols, r - 1, c - 1, true) +
        //              DFS(board, rows, cols, r - 1, c + 1, true) +
        //              DFS(board, rows, cols, r + 1, c - 1, true);
        //    }

        //    return val;
        //}
    }
}
