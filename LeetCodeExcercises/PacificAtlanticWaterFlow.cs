namespace LeetCodeExcercises
{
    public static class PacificAtlanticWaterFlow
    {
        public static IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            int rows = heights.Length;
            int columns = heights[0].Length;

            bool[,] pac = new bool[rows, columns];
            bool[,] atl = new bool[rows, columns];

            for (int c = 0; c < columns; c++)
            {
                Dfs(0, c, pac, heights[0][c], heights);
                Dfs(rows - 1, c, atl, heights[rows - 1][c], heights);
            }

            for (int r = 0; r < rows; r++)
            {
                Dfs(r, 0, pac, heights[r][0], heights);
                Dfs(r, columns - 1, atl, heights[r][columns - 1], heights);
            }

            List<IList<int>> res = new();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (pac[i, j] && atl[i, j])
                    {
                        res.Add(new int[] { i, j });
                    }
                }
            }
            return res;
        }

        public static void Dfs(int r, int c, bool[,] set, int prevHeight, int[][] heights)
        {
            if (r < 0 || c < 0 || r == heights.Length || c == heights[0].Length || set[r, c] || heights[r][c] < prevHeight)
            {
                return;
            };

            set[r, c] = true;


            Dfs(r - 1, c, set, heights[r][c], heights);
            Dfs(r + 1, c, set, heights[r][c], heights);
            Dfs(r, c - 1, set, heights[r][c], heights);
            Dfs(r, c + 1, set, heights[r][c], heights);

        }
    }
}
