namespace LeetCodeExcercises
{
    public class KthLargestElementInAStream
    {
        private readonly IDictionary<int, int> minHeap;
        private readonly int k;
        private int size = 0;
        public KthLargestElementInAStream(int k, int[] nums)
        {
            this.k = k;
            minHeap = new SortedDictionary<int, int>();
            foreach (var num in nums)
                Add(num);
        }

        public int Add(int val)
        {
            if (minHeap.ContainsKey(val))
                minHeap[val]++;
            else
                minHeap[val] = 1;
            size++;

            if (size > k)
            {
                var pair = minHeap.First();
                if (pair.Value > 1)
                    minHeap[pair.Key]--;
                else
                    minHeap.Remove(pair.Key);

                size--;
            }

            return minHeap.Keys.First();
        }
    }
}
