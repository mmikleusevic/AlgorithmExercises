namespace LeetCodeExcercises
{
    public static class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return intervals;

            Array.Sort(intervals, (a, b) =>
            {
                var comp = a[0].CompareTo(b[0]);
                if (comp == 0)
                    comp = a[1].CompareTo(b[1]);
                return comp;
            });

            List<int[]> set = new() { new int[] { intervals[0][0], intervals[0][1] } };

            for (int i = 1; i < intervals.Length; i++)
            {
                int lastEnd = set[set.Count - 1][1];
                if (intervals[i][0] <= lastEnd)
                {
                    set[set.Count - 1][1] = Math.Max(lastEnd, intervals[i][1]);
                }
                else
                {
                    set.Add(intervals[i]);
                }
            }

            return set.ToArray();
        }
    }
}
