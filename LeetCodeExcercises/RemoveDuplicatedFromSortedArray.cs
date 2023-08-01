namespace LeetCodeExcercises
{
    public static class RemoveDuplicatedFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int prev = nums[0];
            int left = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > prev)
                {
                    nums[left] = nums[i];
                    left++;
                }
                prev = nums[i];
            }

            return left;
        }
    }
}
