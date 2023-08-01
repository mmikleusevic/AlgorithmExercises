namespace LeetCodeExcercises
{
    public static class GenerateParenthesis
    {
        public static IList<string> GenerateParenthesisMethod(int n)
        {
            List<string> result = new List<string>();
            if (n > 0) { BackTrack(n, n, result, ""); }

            return result;
        }

        public static void BackTrack(int l, int r, IList<string> results, string s)
        {
            if (l == 0)
            {
                s += new string(')', r);
                results.Add(s);
                return;
            }

            BackTrack(l - 1, r, results, s + "(");
            if (r > l)
            {
                BackTrack(l, r - 1, results, s + ")");
            }
        }
    }
}
