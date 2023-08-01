namespace LeetCodeExcercises
{
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            //HashSet<string> seen = new HashSet<string>();
            //for (int i = 0; i < 9; ++i)
            //{
            //    for (int j = 0; j < 9; ++j)
            //    {
            //        if (board[i][j] != '.')
            //        {
            //            string b = "(" + board[i][j] + ")";
            //            if (!seen.Add(b + i) || !seen.Add(j + b) || !seen.Add(i / 3 + b + j / 3))
            //                return false;
            //        }
            //    }
            //}
            //return true;

            //bolje rješenje

            int squareId;
            int value;
            var colUsed = new bool[9, 9];
            var rowUsed = new bool[9, 9];
            var squareUsed = new bool[9, 9];

            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    value = board[row][column] - '0' - 1;
                    if (value > 8 || value < 0) { continue; }
                    squareId = (row / 3) * 3 + column / 3;
                    if (colUsed[column, value] || rowUsed[row, value] || squareUsed[squareId, value]) { return false; }

                    colUsed[column, value] = rowUsed[row, value] = squareUsed[squareId, value] = true;
                }
            }

            return true;
        }
    }
}
