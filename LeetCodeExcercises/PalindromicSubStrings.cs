namespace LeetCodeExcercises
{
    public static class PalindromicSubStrings
    {
        public static int CountSubstrings(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                result += FindPalindrome(i, i, s);
                result += FindPalindrome(i, i + 1, s);
            }
            return result;
        }

        public static int FindPalindrome(int l, int r, string s)
        {
            int result = 0;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                result++;
                l--;
                r++;
            }
            return result;
        }
    }
}
