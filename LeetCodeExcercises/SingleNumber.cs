namespace LeetCodeExcercises
{
    public static class SingleNumber
    {
        public static int SingleNumberMethod(int[] nums)
        {
            var a = 0;
            foreach (var num in nums)
            {
                a = a ^ num;
            }

            return a;
        }
    }
}
