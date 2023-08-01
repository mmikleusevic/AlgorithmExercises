namespace LeetCodeExcercises
{
    public static class SqrtX
    {
        public static int MySqrt(int x)
        {
            long l = 0;
            long r = x;
            long m;
            long res = 0;

            while (l <= r)
            {
                m = l + (r - l) / 2;
                if (m * m > x)
                {
                    r = m - 1;
                }
                else if (m * m < x)
                {
                    l = m + 1;
                    res = m;
                }
                else
                {
                    return (int)m;
                }
            }
            return (int)res;
        }
    }
}
