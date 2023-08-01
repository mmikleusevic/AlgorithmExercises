namespace LeetCodeExcercises
{
    public static class InfobipLongNumberPossibilities
    {
        public static int Solve(int N, int[] A)
        {
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] < 9)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
