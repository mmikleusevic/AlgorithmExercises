namespace LeetCodeExcercises
{
    public static class _4SumII
    {
        public static int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> map = new();
            foreach (int k in nums3)
            {
                foreach (int l in nums4)
                {
                    if (!map.ContainsKey(k + l))
                    {
                        map.Add(k + l, 0);
                    }
                    map[k + l]++;
                }
            }
            int count = 0;
            foreach (int i in nums1)
            {
                foreach (int j in nums2)
                {
                    count += map.GetValueOrDefault(-(i + j), 0);
                }
            }
            return count;
        }
    }
}
