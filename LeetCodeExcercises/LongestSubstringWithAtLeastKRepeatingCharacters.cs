namespace LeetCodeExcercises
{
    public static class LongestSubstringWithAtLeastKRepeatingCharacters
    {
        public static int LongestSubstring(string s, int k)
        {
            int n = s.Length;

            Dictionary<char, int> count = new();
            foreach (char c in s)
            {
                if (!count.ContainsKey(c))
                {
                    count.Add(c, 0);
                }
                count[c]++;
            }
            int mid = 0;
            while (mid < n && count[s[mid]] >= k)
            {
                mid++;
            }
            if (mid == n) return n;

            int left = LongestSubstring(s.Substring(0, mid), k);

            while (mid < n && count[s[mid]] < k)
            {
                mid++;
            }
            int right = LongestSubstring(s.Substring(mid), k);
            return Math.Max(left, right);
        }
    }
}
