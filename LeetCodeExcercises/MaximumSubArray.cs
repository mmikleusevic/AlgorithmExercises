namespace LeetCodeExcercises
{
    public static class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return int.MinValue;

            int currSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(nums[i], currSum + nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}
