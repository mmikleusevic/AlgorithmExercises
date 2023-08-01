namespace LeetCodeExcercises
{
    public static class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int right = s.Length - 1;
            int left = 0;
            s = s.ToLower();

            while (left < right)
            {

                while (left < right && !AlphaNumeric(s[left]))
                {
                    left++;
                }

                while (right > left && !AlphaNumeric(s[right]))
                {
                    right--;
                }

                if (s[left] != s[right]) return false;

                left++;
                right--;
            }

            return true;
        }

        public static bool AlphaNumeric(char c)
        {
            return c >= '0' && c <= '9' || c >= 'a' && c <= 'z';
        }
    }
}
