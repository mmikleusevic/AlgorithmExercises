namespace LeetCodeExcercises
{
    public static class HouseRobberII
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int temp = nums[0];
            nums[0] = 0;

            int result1 = Helper(nums);

            nums[0] = temp;
            nums[nums.Length - 1] = 0;

            int result2 = Helper(nums);

            return Math.Max(result1, result2);
        }

        public static int Helper(int[] arr)
        {
            int rob1 = 0;
            int rob2 = 0;

            foreach (int money in arr)
            {
                int temp = Math.Max(money + rob1, rob2);
                rob1 = rob2;
                rob2 = temp;
            }
            return rob2;
        }
    }
}
