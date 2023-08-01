namespace LeetCodeExcercises
{
    public static class SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new();
            int left = 0;
            int right = matrix[0].Length - 1;
            int top = 0;
            int bottom = matrix.Length - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top += 1;
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(matrix[i][right]);
                }
                right -= 1;

                if (!(left <= right && top <= bottom))
                {
                    break;
                }

                for (int i = right; i >= left; i--)
                {
                    res.Add(matrix[bottom][i]);
                }
                bottom -= 1;

                for (int i = bottom; i >= top; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left += 1;
            }
            return res;
        }
    }
}
