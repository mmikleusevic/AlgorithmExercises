namespace LeetCodeExcercises
{
    public static class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            if (n < 4) { return n; }

            int x1 = 2;
            int x2 = 3;
            int temp;

            for (int i = 4; i <= n; i++)
            {
                temp = x1 + x2;
                x1 = x2;
                x2 = temp;
            }

            return x2;
        }
    }
}
