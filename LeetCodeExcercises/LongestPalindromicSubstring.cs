using System.Text;

namespace LeetCodeExcercises
{
    public static class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            StringBuilder sb = new();

            for (int i = 0; i < s.Length; i++)
            {
                FindPalindrome(i, i, s, sb);
                FindPalindrome(i, i + 1, s, sb);
            }
            return sb.ToString();
        }

        public static void FindPalindrome(int l, int r, string s, StringBuilder sb)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l + 1 > sb.Length)
                {
                    sb.Clear();
                    sb.Append(s.Substring(l, r - l + 1));
                }
                l -= 1;
                r += 1;
            }
        }
    }
}
