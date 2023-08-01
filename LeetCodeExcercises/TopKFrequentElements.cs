namespace LeetCodeExcercises
{
    public static class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            List<int>[] bucket = new List<int>[nums.Length + 1];
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (!frequencyMap.ContainsKey(n))
                {
                    frequencyMap.Add(n, 0);
                }
                frequencyMap[n]++;
            }

            foreach (int key in frequencyMap.Keys)
            {
                int frequency = frequencyMap.GetValueOrDefault(key);
                if (bucket[frequency] == null)
                {
                    bucket[frequency] = new List<int>();
                }
                bucket[frequency].Add(key);
            }

            int[] res = new int[k];

            int i = 0;
            for (int pos = bucket.Length - 1; pos >= 0; pos--)
            {
                if (bucket[pos] != null)
                {
                    foreach (int n in bucket[pos])
                    {
                        res[i] = n;
                        k--;
                        if (k == 0) return res;
                        i++;
                    }
                }
            }
            return res;

            //Moje rješenje

            //Dictionary<int, int> map = new();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!map.ContainsKey(nums[i]))
            //    {
            //        map[nums[i]] = 0;
            //    }
            //    map[nums[i]]++;
            //}

            //return map.OrderByDescending(a => a.Value).Take(k).Select(a => a.Key).ToArray();
        }
    }
}
