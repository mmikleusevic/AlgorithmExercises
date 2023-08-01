namespace LeetCodeExcercises
{
    public static class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            int left = 0;
            int right = matrix[0].Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    int top = left;
                    int bottom = right;

                    int topLeft = matrix[top][left + i];
                    matrix[top][left + i] = matrix[bottom - i][left];
                    matrix[bottom - i][left] = matrix[bottom][right - i];
                    matrix[bottom][right - i] = matrix[top + i][right];
                    matrix[top + i][right] = topLeft;
                }
                right--;
                left++;
            }
        }
    }
}
