﻿namespace LeetCodeExcercises
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;

            for (int i = 1; i < nums.Length; i++)
                result[i] = result[i - 1] * nums[i - 1];

            int rightSide = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= rightSide;
                rightSide *= nums[i];
            }

            return result;
        }
    }
}
