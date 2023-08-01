namespace LeetCodeExcercises
{
    public static class MaximumProductSubArray
    {
        public static int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int minProduct = 1;
            int maxProduct = 1;
            int result = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    var temp = minProduct;
                    minProduct = maxProduct;
                    maxProduct = temp;
                }

                minProduct = Math.Min(nums[i], minProduct * nums[i]);
                maxProduct = Math.Max(nums[i], maxProduct * nums[i]);

                result = Math.Max(result, maxProduct);
            }

            return result;
        }
    }
}
