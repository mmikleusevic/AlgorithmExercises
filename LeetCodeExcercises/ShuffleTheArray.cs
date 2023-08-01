namespace LeetCodeExcercises
{
    public static class ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            //moje rješenje dodatna memorija

            Stack<int> s = new();
            int r = n;
            int i = 0;
            int l = 0;
            while (s.Count != nums.Length)
            {
                if (i % 2 == 0)
                {
                    s.Push(nums[l]);
                    l++;
                }
                else
                {
                    s.Push(nums[r]);
                    r++;
                }
                i++;
            }

            for (int j = nums.Length - 1; j >= 0; j--)
            {
                nums[j] = s.Pop();
            }

            return nums;
        }
    }
}
