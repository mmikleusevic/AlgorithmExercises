namespace LeetCodeExcercises
{
    public static class WiggleSort
    {
        public static void WiggleSortMethod(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 0 && nums[i] > nums[i - 1] ||
                    i % 2 == 1 && nums[i] < nums[i - 1])
                {
                    var temp = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = temp;
                }
            }
        }
    }
}
