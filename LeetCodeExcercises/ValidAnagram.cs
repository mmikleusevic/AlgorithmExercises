namespace LeetCodeExcercises
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            // Using unicode

            if (s.Length != t.Length) return false;

            var sCount = new int[26];
            foreach (var ch in s)
            {
                sCount[ch - 'a']++;
            }

            var tCount = new int[26];
            foreach (var ch in t)
            {
                tCount[ch - 'a']++;
            }

            return sCount.SequenceEqual(tCount);

            // Sort
            //if (s.Length != t.Length) return false;

            //s = string.Concat(s.OrderBy(c => c));
            //t = string.Concat(t.OrderBy(c => c));

            //return s == t;

            // Dictionary

            //if (s.Length != t.Length) return false;

            //Dictionary<char, int> map = new();

            //foreach (char c in s)
            //{
            //    if (map.ContainsKey(c))
            //    {
            //        map[c]++;
            //    }
            //    else
            //    {
            //        map.Add(c, 1);
            //    }
            //}

            //foreach (char c in t)
            //{
            //    if (map.ContainsKey(c))
            //    {
            //        map[c]--;
            //        if (map[c] == 0)
            //        {
            //            map.Remove(c);
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return map.Count == 0;
        }
    }
}
