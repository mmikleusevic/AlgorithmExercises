namespace LeetCodeExcercises
{
    public static class CoinChange
    {
        public static int CoinChangeMethod(int[] coins, int amount)
        {
            var dp = new long[amount + 1];
            Array.Fill(dp, int.MaxValue);

            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (var coin in coins)
                {
                    if (coin <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : (int)dp[amount];
        }
    }
}
