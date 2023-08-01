using System.Text;

namespace LeetCodeExcercises
{
    internal static class LargestNumber
    {
        public static string LargestNumberMethod(int[] nums)
        {
            if (nums.Length == 0) return string.Empty;
            if (nums.Length == 1) return nums[0].ToString();

            var numsStr = nums.Select(num => num.ToString()).ToArray();
            Array.Sort(numsStr, (a, b) => (b + a).CompareTo(a + b));

            if (numsStr[0] == "0") return "0";

            var sb = new StringBuilder();
            foreach (var str in numsStr)
                sb.Append(str);

            return sb.ToString();
        }
    }
}
