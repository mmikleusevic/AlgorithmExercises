namespace LeetCodeExcercises
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagramsMethod(string[] strs)
        {
            //Po meni bolje rješenje za c#
            Dictionary<string, IList<string>> map = new();
            string key = string.Empty;
            char[] ch;

            foreach (string s in strs)
            {
                ch = s.ToCharArray();
                Array.Sort(ch);
                key = new string(ch);
                if (!map.ContainsKey(key))
                {
                    map.Add(key, new List<string>());
                }
                map[key].Add(s);
            }

            return map.Values.ToList();

            //Drugo rješenje koje je sida isusova
            //Dictionary<int[], IList<string>> map = new();

            //foreach(string s  in strs)
            //{
            //    int[] chars = new int[26];

            //    foreach(char c in s)
            //    {
            //        chars[c - 'a']++;
            //    }
            //    var check = map.Keys.Where(a => a.SequenceEqual(chars)).FirstOrDefault();
            //    if (check == null)
            //    {
            //        map.Add(chars, new List<string>());
            //        check = chars;
            //    }
            //    map[check].Add(s);
            //}

            //return map.Values.ToList();            
        }
    }
}
