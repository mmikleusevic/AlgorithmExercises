namespace LeetCodeExcercises
{
    public static class InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            HashSet<int[]> set = new();
            if ((intervals == null || intervals.Length == 0) && (newInterval != null || newInterval.Length > 0))
            {
                set.Add(newInterval);
                return set.ToArray();
            }
            if (newInterval == null || newInterval.Length == 0)
            {
                return intervals;
            }

            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[0] > intervals[i][1])
                {
                    set.Add(intervals[i]);
                }
                else if (newInterval[1] < intervals[i][0])
                {
                    set.Add(newInterval);

                    for (int j = i; j < intervals.Length; j++)
                    {
                        set.Add(intervals[j]);
                    }

                    return set.ToArray();
                }
                else
                {
                    newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                    newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                }
            }
            set.Add(newInterval);

            return set.ToArray();
        }
    }
}
