namespace LeetCodeExcercises
{
    public static class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (k == 0) return;

            Swap(nums, 0, nums.Length - 1);
            Swap(nums, 0, k - 1);
            Swap(nums, k, nums.Length - 1);
        }

        public static void Swap(int[] nums, int l, int r)
        {
            while (l < r)
            {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
                r--;
            }
        }
    }
}
