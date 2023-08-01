namespace LeetCodeExcercises
{
    public static class KthLargestElementInASortedMatrix
    {
        public static int KthSmallest(int[][] matrix, int k)
        {
            int low = matrix[0][0];
            int high = matrix[matrix.Length - 1][matrix.Length - 1];
            int kthValue = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int count = GetNumElementLessThanOrEqualToValue(matrix, mid);

                if (count >= k)
                {
                    kthValue = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return kthValue;
        }

        public static int GetNumElementLessThanOrEqualToValue(int[][] matrix, int kthValue)
        {
            int row = matrix.Length - 1;
            int col = 0;
            int count = 0;

            while (row >= 0 && col < matrix.Length)
            {
                if (matrix[row][col] <= kthValue)
                {
                    count += row + 1;
                    col++;
                }
                else
                {
                    row--;
                }
            }

            return count;
        }
    }
}
