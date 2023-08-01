namespace LeetCodeExcercises
{
    public static class PerfectSquares
    {
        public static int NumSquares(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int j = 1, min = int.MaxValue;
                while (i - j * j >= 0)
                {
                    min = Math.Min(min, dp[i - j * j] + 1);
                    j++;
                }
                dp[i] = min;
            }

            return dp[n];
        }
    }
}
