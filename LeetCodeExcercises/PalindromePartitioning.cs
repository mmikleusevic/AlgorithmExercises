namespace LeetCodeExcercises
{
    public static class PalindromePartitioning
    {
        public static IList<IList<string>> Partition(string s)
        {
            List<IList<string>> result = new();

            if (s == null || s.Length == 0) return result;

            Backtracking(s, result, new List<string>(), 0);

            return result;
        }

        public static void Backtracking(string s, List<IList<string>> result, List<string> list, int i)
        {
            if (i >= s.Length)
            {
                result.Add(new List<string>(list));
                return;
            }


            for (int j = i; j < s.Length; j++)
            {
                if (!IsPalindrome(s, i, j)) continue;

                list.Add(s.Substring(i, j - i + 1));

                Backtracking(s, result, list, j + 1);

                list.RemoveAt(list.Count - 1);
            }
        }

        public static bool IsPalindrome(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l] != s[r]) return false;

                l++;
                r--;
            }
            return true;
        }
    }
}
