namespace LeetCodeExcercises
{
    public class InsertDeleteGetRandomO1
    {
        private Random random;
        private List<int> list;
        Dictionary<int, int> map;
        public InsertDeleteGetRandomO1()
        {
            random = new Random();
            list = new List<int>();
            map = new Dictionary<int, int>();
        }

        public bool Insert(int val)
        {
            if (!map.ContainsKey(val))
            {
                map.Add(val, list.Count);
                list.Add(val);
                return true;
            }
            return false;
        }

        public bool Remove(int val)
        {
            if (!map.ContainsKey(val)) return false;
            if (map[val] != list.Count - 1)
            {
                list[map[val]] = list[list.Count - 1];
                map[list[list.Count - 1]] = map[val];
            }
            map.Remove(val);
            list.RemoveAt(list.Count - 1);
            return true;
        }

        public int GetRandom()
        {
            var index = random.Next(list.Count);
            return list[index];
        }
    }
}
