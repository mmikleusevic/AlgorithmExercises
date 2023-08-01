namespace LeetCodeExcercises
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            HashSet<int> set = new();

            long output = 0;
            while (!set.Contains(n))
            {
                set.Add(n);

                n = SumOfSquares(n);

                if (n == 1) return true;
            }

            return false;
        }

        public static int SumOfSquares(int n)
        {
            int output = 0;
            while (n != 0)
            {
                int digit = n % 10;
                digit = (int)Math.Pow(digit, 2);
                output += digit;
                n = n / 10;
            }
            return output;
        }
    }
}
