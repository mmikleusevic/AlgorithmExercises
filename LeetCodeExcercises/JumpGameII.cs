namespace LeetCodeExcercises
{
    public static class JumpGameII
    {
        public static int Jump(int[] nums)
        {
            int jumps = 0;
            int curEnd = 0;
            int curFarthest = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                curFarthest = Math.Max(curFarthest, i + nums[i]);
                if (i == curEnd)
                {
                    jumps++;
                    curEnd = curFarthest;
                    if (curEnd == nums.Length - 1) return jumps;
                }
            }
            return jumps;
        }
    }
}
