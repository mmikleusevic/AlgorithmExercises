using System.Text.RegularExpressions;

namespace LeetCodeExcercises
{
    public static class InfobipFindPhoneNumber
    {
        public static string FindNumber(string s)
        {
            Regex pattern = new("[0-9]{10}");
            Match match = pattern.Match(s);

            if (match.Success) return match.Value;

            return "-1";
        }

        //public static string FindNumber(string s)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i + 9 < s.Length && char.IsDigit(s[i]) && char.IsDigit(s[i + 9]))
        //        {
        //            sb.Append(s[i]);
        //            int size = i + 9;
        //            i++;
        //            for (; i <= size; i++)
        //            {
        //                if (!char.IsDigit(s[i]))
        //                {
        //                    sb.Clear();
        //                    break;
        //                }
        //                else
        //                {
        //                    sb.Append(s[i]);
        //                }
        //            }
        //            if (sb.Length == 10) return sb.ToString();
        //        }
        //    }
        //    return "-1";
        //}
    }
}
