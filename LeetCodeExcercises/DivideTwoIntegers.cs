namespace LeetCodeExcercises
{
    public static class DivideTwoIntegers
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0) { return 0; }

            uint a = dividend > 0 ? (uint)dividend : (uint)-dividend;
            uint b = divisor > 0 ? (uint)divisor : (uint)-divisor;

            uint result = 0;
            uint c = 0;
            var index = 0;
            while (a >= b)
            {
                c = b;
                for (index = 0; a >= c && c != 0; index++, c *= 2)
                {
                    a -= c;
                    result += (uint)index + 1;
                }
            }

            return (dividend ^ divisor) >> 31 == -1
                ? (int)-result
                : result > int.MaxValue ? int.MaxValue : (int)result;
        }
    }
}
