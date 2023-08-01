namespace LeetCodeExcercises
{
    public static class NonOverlappingIntervals
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0 || intervals.Length == 1) return 0;

            Array.Sort(intervals, (a, b) =>
            {
                int comp = a[0].CompareTo(b[0]);
                if (comp == 0)
                    comp = a[1].CompareTo(b[1]);
                return comp;
            });

            int end = intervals[0][1];
            int count = 0;

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= end)
                {
                    end = intervals[i][1];
                }
                else
                {
                    count++;
                    end = Math.Min(end, intervals[i][1]);
                }
            }
            return count;
        }
    }
}
