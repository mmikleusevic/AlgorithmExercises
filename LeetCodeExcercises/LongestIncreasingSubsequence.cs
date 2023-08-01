namespace LeetCodeExcercises
{
    public static class LongestIncreasingSubsequence
    {
        public static int LengthOfLIS(int[] nums)
        {
            int[] lis = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                lis[i] = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        lis[i] = Math.Max(lis[i], 1 + lis[j]);
                    }
                }
            }
            return lis.Max();
        }
    }
}
