namespace LeetCodeExcercises
{
    public static class MoveZeroes
    {
        public static void MoveZeroesMethod(int[] nums)
        {
            if (nums == null) return;

            int left = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    int temp = nums[r];
                    nums[r] = nums[left];
                    nums[left] = temp;
                    left++;
                }
            }
        }
    }
}
