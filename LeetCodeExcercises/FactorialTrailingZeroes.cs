namespace LeetCodeExcercises
{
    public static class FactorialTrailingZeroes
    {
        public static int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
}
