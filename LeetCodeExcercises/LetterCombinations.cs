namespace LeetCodeExcercises
{
    public static class LetterCombinations
    {
        public static IList<string> LetterCombinationsMethod(string digits)
        {
            //jedno rješenje

            if (digits.Length == 0 || digits == null) return new List<string>();

            string[] phoneChars = new string[] { "abc",
                                                 "def",
                                                 "ghi",
                                                 "jkl",
                                                 "mno",
                                                 "pqrs",
                                                 "tuv",
                                                 "wxyz"
                                               };

            List<string> results = new() { "" };

            foreach (var digit in digits)
            {
                var keys = phoneChars[digit - '0' - 2];
                if (keys.Length == 0) continue;

                var temp = new List<string>();
                foreach (var result in results)
                    foreach (var ch in keys)
                        temp.Add(result + ch.ToString());

                results = temp;
            }

            if (results.Count == 1 && results[0] == "") results.Clear();
            return results;
        }
    }
}
