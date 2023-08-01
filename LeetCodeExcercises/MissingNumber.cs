namespace LeetCodeExcercises
{
    public static class MissingNumber
    {
        public static int MissingNumbers(int[] nums)
        {
            int xor = 0;
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                xor = xor ^ i ^ nums[i];
            }

            return xor ^ i;
        }
    }
}
