namespace LeetCodeExcercises
{
    public static class WiggleSortII
    {
        public static void WiggleSortMethod(int[] nums)
        {
            int[] x = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                x[i] = nums[i];
            }
            Array.Sort(x);

            int j = x.Length - 1;
            int k = (x.Length - 1) / 2;
            int n = nums.Length;
            for (int l = 0; l < n; l += 2)
            {
                nums[l] = x[k--];
            }
            for (int l = 1; l < n; l += 2)
            {
                nums[l] = x[j--];
            }
        }
    }
}
