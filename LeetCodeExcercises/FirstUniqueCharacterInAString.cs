namespace LeetCodeExcercises
{
    public static class FirstUniqueCharacterInAString
    {
        public static int FirstUniqChar(string s)
        {
            var counts = new int[26];
            foreach (var ch in s)
            {
                counts[ch - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i] - 'a'] == 1) return i;
            }

            return -1;


            // Moje rješenje

            //int result = -1;
            //Dictionary<char, int> map = new();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!map.ContainsKey(s[i]))
            //    {
            //        map.Add(s[i], 1);
            //    }
            //    else
            //    {
            //        map[s[i]]++;
            //    }
            //}

            //char toFind = map.FirstOrDefault(a => a.Value == 1).Key;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == toFind) return result = i;
            //}
            //return result;
        }
    }
}
