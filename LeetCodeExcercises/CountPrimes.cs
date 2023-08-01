namespace LeetCodeExcercises
{
    public static class CountPrimes
    {
        public static int CountPrimesMethod(int n)
        {
            bool[] notPrime = new bool[n];
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!notPrime[i])
                {
                    count++;
                    for (int j = 2; j * i < n; j++)
                    {
                        notPrime[i * j] = true;
                    }
                }
            }

            return count;
        }
    }
}
