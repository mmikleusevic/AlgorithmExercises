namespace LeetCodeExcercises
{
    public static class FindPeakElement
    {
        public static int FindPeakElementMethod(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (m > 0 && nums[m] < nums[m - 1])
                {
                    r = m - 1;
                }
                else if (m < nums.Length - 1 && nums[m] < nums[m + 1])
                {
                    l = m + 1;
                }
                else
                {
                    return m;
                }
            }
            return l;
        }
    }
}
