namespace LeetCodeExcercises
{
    public static class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            if (s.Length == 0) return 0;

            int[] memo = new int[s.Length + 1];
            memo[s.Length] = 1;
            memo[s.Length - 1] = s[s.Length - 1] == '0' ? 0 : 1;

            for (var i = s.Length - 2; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    memo[i] = 0;
                }
                else
                {
                    if (int.Parse(s.Substring(i, 2)) <= 26)
                    {
                        memo[i] = memo[i + 1] + memo[i + 2];
                    }
                    else
                    {
                        memo[i] = memo[i + 1];
                    }
                }
            }
            return memo[0];
        }
    }
}
