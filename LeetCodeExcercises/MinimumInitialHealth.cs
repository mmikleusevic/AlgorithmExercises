namespace LeetCodeExcercises
{
    public static class MinimumInitialHealth
    {
        public static int MinimumEffort(int[][] tasks)
        {
            Array.Sort(tasks, (x, y) =>
            {
                if (x[1] - x[0] > y[1] - y[0])
                    return -1;
                return 1;
            });

            int energy = 0;
            int res = 0;
            for (int i = 0; i < tasks.Length; i++)
            {
                if (energy < tasks[i][1])
                {
                    int borrow = tasks[i][1] - energy;
                    res += borrow;
                    energy += borrow;
                }
                energy = energy - tasks[i][0];
            }
            return res;
        }
    }
}
