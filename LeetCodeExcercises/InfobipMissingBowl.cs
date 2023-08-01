namespace LeetCodeExcercises
{
    public static class InfobipMissingBowl
    {
        public static int Solve(int N, int[] A)
        {
            if (N == 0) return 0;

            int max = A[0] + A[A.Length - 1];
            int m = A.Length / 2;
            return max - A[m];
        }
    }
}
