namespace LeetCodeExcercises
{
    public static class Subsets
    {
        public static IList<IList<int>> SubsetsMethod(int[] nums)
        {
            List<IList<int>> result = new();

            if (nums == null || nums.Length == 0) { return result; }

            DFS(nums, 0, result, new List<int>());

            return result;
        }

        public static void DFS(int[] nums, int i, List<IList<int>> result, List<int> list)
        {
            if (i >= nums.Length)
            {
                result.Add(new List<int>(list));
                return;
            }

            list.Add(nums[i]);
            DFS(nums, i + 1, result, list);

            list.Remove(nums[i]);
            DFS(nums, i + 1, result, list);
        }
    }
}
