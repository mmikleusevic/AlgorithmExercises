namespace LeetCodeExcercises
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];

            string res = string.Empty;

            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (string s in strs)
                {
                    if (i == s.Length || s[i] != strs[0][i])
                    {
                        return res;
                    }
                }
                res += strs[0][i];
            }
            return res;
        }
    }
}
