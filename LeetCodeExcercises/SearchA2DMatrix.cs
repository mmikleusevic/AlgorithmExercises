namespace LeetCodeExcercises
{
    public static class SearchA2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0) return false;

            int columnLength = matrix[0].Length;
            int l = 0;
            int r = matrix.Length * columnLength - 1;
            int i;
            int j;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                i = mid / columnLength;
                j = mid % columnLength;

                if (matrix[i][j] < target) { l = mid + 1; }
                else if (matrix[i][j] > target) { r = mid - 1; }
                else { return true; }
            }
            return false;
        }
    }
}
