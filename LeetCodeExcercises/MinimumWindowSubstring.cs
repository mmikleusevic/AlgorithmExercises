namespace LeetCodeExcercises
{
    public static class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length) { return string.Empty; }

            Dictionary<char, int> countT = new();
            Dictionary<char, int> window = new();

            foreach (char c in t)
            {
                countT[c] = 1 + countT.GetValueOrDefault(c, 0);
            }

            int have = 0;
            int need = countT.Count;
            int[] res = new int[] { -1, -1 };
            int resLen = int.MaxValue;
            int l = 0;
            int r;

            for (r = 0; r < s.Length; r++)
            {
                char c = s[r];
                window[c] = 1 + window.GetValueOrDefault(c, 0);

                if (countT.ContainsKey(c) && window[c] == countT[c])
                {
                    have += 1;
                }
                while (have == need)
                {
                    if (r - l + 1 < resLen)
                    {
                        res[0] = l;
                        res[1] = r;
                        resLen = (r - l + 1);
                    }
                    window[s[l]] -= 1;
                    if (countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]])
                    {
                        have -= 1;
                    }
                    l += 1;
                }
            }

            if (res[0] == -1 || res[1] == -1) return string.Empty;

            l = res[0];

            return resLen != int.MaxValue ? s.Substring(l, resLen) : string.Empty;
        }
    }
}
