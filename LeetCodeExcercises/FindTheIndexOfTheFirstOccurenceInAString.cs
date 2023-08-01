namespace LeetCodeExcercises
{
    public static class FindTheIndexOfTheFirstOccurenceInAString
    {
        public static int StrStr(string haystack, string needle)
        {

            var needleLength = needle.Length;
            if (needleLength == 0) { return 0; }

            for (int i = 0; i < haystack.Length + 1 - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
