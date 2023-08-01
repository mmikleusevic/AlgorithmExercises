namespace LeetCodeExcercises
{
    public static class CountingBits
    {
        public static int[] CountBits(int n)
        {
            int[] array = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                int j = i;
                while (j != 0)
                {
                    array[i] += j & 1;
                    j = j >> 1;
                }
            }

            return array;
        }
    }
}
