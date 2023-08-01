namespace LeetCodeExcercises
{
    public static class NumberOf1Bits
    {
        public static int HammingWeight(uint n)
        {
            uint ones = 0;
            while (n != 0)
            {
                ones += n & 1;
                n = n >> 1;
            }
            return (int)ones;
        }
    }
}
