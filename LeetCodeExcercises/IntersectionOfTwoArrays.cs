namespace LeetCodeExcercises
{
    public static class IntersectionOfTwoArrays
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> result = new();
            int i = 0;
            int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
            }
            return result.ToArray();

            //Ok rješenje
            //if (nums2.Length < nums1.Length) return Intersect(nums2, nums1);

            //var counts = new Dictionary<int, int>();
            //foreach (var num in nums1)
            //{
            //    if (!counts.ContainsKey(num))
            //        counts[num] = 1;
            //    else
            //        counts[num]++;
            //}

            //var result = new List<int>();
            //foreach (var num in nums2)
            //{
            //    if (counts.ContainsKey(num) && counts[num] > 0)
            //    {
            //        result.Add(num);
            //        counts[num]--;
            //    }
            //}
            //return result.ToArray();

            //Moje polurješenje
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    min = Math.Min(min, nums1[i]);
            //    max = Math.Max(max, nums1[i]);
            //}

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    min = Math.Max(min, nums2[i]);
            //    max = Math.Min(max, nums2[i]);
            //}
            //return new int[] { min, max };
        }
    }
}
