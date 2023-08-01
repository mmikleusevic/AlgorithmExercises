namespace LeetCodeExcercises
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var map = new Dictionary<int, int>();
            var maxLen = 0;
            var lastRepeatPos = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]) && lastRepeatPos < map[s[i]])
                    lastRepeatPos = map[s[i]];
                if (maxLen < i - lastRepeatPos)
                    maxLen = i - lastRepeatPos;
                map[s[i]] = i;
            }

            return maxLen;


            /*
                if(string.IsNullOrEmpty(s)) return 0;

                HashSet<char> set = new();
                int l = 0;
                int res = 0;

                for (int r = 0; r < s.Length; r++)
                {
                    while(set.Contains(s[r])){
                        set.Remove(s[l]);
                        l++;
                    }
                    set.Add(s[r]);
                    res = Math.Max(res, set.Count());
                }

                return res; 
            */
        }
    }
}
