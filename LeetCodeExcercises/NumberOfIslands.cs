namespace LeetCodeExcercises
{
    public static class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            if (grid == null) return 0;

            int rows = grid.Length;
            int columns = grid[0].Length;
            bool[,] visited = new bool[rows, columns];
            int islands = 0;
            Queue<int[]> q = new Queue<int[]>();
            int[][] directions = new int[4][];
            directions[0] = new int[] { 1, 0 };
            directions[1] = new int[] { -2, 0 };
            directions[2] = new int[] { 1, 1 };
            directions[3] = new int[] { 0, -2 };

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (grid[r][c] == '1' && !visited[r, c])
                    {
                        Bfs(r, c, rows, columns, grid, visited, q, directions);
                        islands++;
                    }
                }
            }
            return islands;
        }

        public static void Bfs(int r, int c, int row, int col, char[][] grid, bool[,] visited, Queue<int[]> q, int[][] directions)
        {
            if (q.Count != 0) q.Dequeue();
            visited[r, c] = true;
            q.Enqueue(new int[] { r, c });

            while (q.Count > 0)
            {
                var array = q.Dequeue();
                r = array[0];
                c = array[1];

                for (int i = 0; i < directions.Length; i++)
                {
                    r = r + directions[i][0];
                    c = c + directions[i][1];
                    if (r < row && r >= 0
                        && c < col && c >= 0
                        && grid[r][c] == '1'
                        && visited[r, c] == false)
                    {
                        q.Enqueue(new int[] { r, c });
                        visited[r, c] = true;
                    }
                }
            }
        }
    }
}
