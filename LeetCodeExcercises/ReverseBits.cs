namespace LeetCodeExcercises
{
    public static class ReverseBits
    {
        public static uint ReverseBitsMethod(uint n)
        {
            if (n == 0) return 0;

            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                result = result << 1;
                result += n & 1;
                n = n >> 1;
            }

            return result;
        }
    }
}
