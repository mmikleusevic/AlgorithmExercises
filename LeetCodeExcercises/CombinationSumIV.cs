namespace LeetCodeExcercises
{
    public static class CombinationSumIV
    {
        public static int CombinationSum4(int[] nums, int target)
        {
            Dictionary<int, int> dp = new();
            dp[0] = 1;

            for (int i = 1; i < target + 1; i++)
            {
                dp[i] = 0;
                foreach (int n in nums)
                {
                    if (dp.TryGetValue(i - n, out int value))
                    {
                        dp[i] += value;
                    }
                }
            }
            return dp[target];
        }
    }
}
