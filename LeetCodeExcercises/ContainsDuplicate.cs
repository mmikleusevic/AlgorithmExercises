namespace LeetCodeExcercises
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateMethod(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (set.Contains(num)) return true;
                set.Add(num);
            }

            return false;
        }
    }
}
