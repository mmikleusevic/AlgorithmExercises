namespace LeetCodeExcercises
{
    public static class SearchA2DMatrixII
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            var n = matrix.Length;
            var i = 0;
            var m = matrix[0].Length - 1;

            while (i < n && m >= 0)
            {
                var cmp = matrix[i][m].CompareTo(target);
                if (cmp == 0) return true;
                else if (cmp > 0) m--;
                else i++;
            }
            return false;
        }
    }
}
