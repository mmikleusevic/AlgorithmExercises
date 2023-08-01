namespace LeetCodeExcercises
{
    public static class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            int maxRight = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxRight)
                {
                    return false;
                }
                if (i + nums[i] > maxRight)
                {
                    maxRight = i + nums[i];
                }
                if (maxRight >= nums.Length - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
