namespace LeetCodeExcercises
{
    public static class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int threeSum = nums[i] + nums[l] + nums[r];
                    if (threeSum > 0) r--;
                    else if (threeSum < 0) l++;
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        while (nums[l] == nums[l - 1] && l < r)
                        {
                            l++;
                        }
                    }
                }
            }

            return res;
        }
    }
}
