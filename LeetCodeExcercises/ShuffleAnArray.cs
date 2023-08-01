namespace LeetCodeExcercises
{
    public class ShuffleAnArray
    {
        private Dictionary<int, int> map;
        private Random rand;
        private int[] nums;
        public ShuffleAnArray(int[] nums)
        {
            map = new Dictionary<int, int>();
            rand = new Random();
            this.nums = nums;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, nums[i]);
                }
            }
        }
        public int[] Reset()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = map[i];
            }
            return nums;
        }

        public int[] Shuffle()
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int j = rand.Next(i + 1);
                Swap(j, i);
            }

            return nums;
        }

        public void Swap(int l, int r)
        {
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
        }
    }
}
