namespace LeetCodeExcercises
{
    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);

            var longestStreak = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(nums[i] - 1))
                {
                    int currentNum = nums[i];
                    int currentStreak = 1;
                    while (hashSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
