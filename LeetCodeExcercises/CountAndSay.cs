using System.Text;

namespace LeetCodeExcercises
{
    public static class CountAndSay
    {
        private static StringBuilder sb = new StringBuilder();
        public static string CountAndSayMethod(int n)
        {
            if (n == 1) return "1";

            string prev = CountAndSayMethod(n - 1);
            if (sb.Length > 0) sb.Clear();

            int count = 0;
            for (int i = 0; i < prev.Length; i++)
            {
                count++;
                if (i == prev.Length - 1 || prev[i] != prev[i + 1])
                {
                    sb.Append(count + prev[i].ToString());
                    count = 0;
                }
            }

            return sb.ToString();
        }
    }
}
