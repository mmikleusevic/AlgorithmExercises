namespace LeetCodeExcercises
{
    public class LRUNode
    {
        public int key;
        public int val;
        public LRUNode prev;
        public LRUNode next;

        public LRUNode(int key, int val)
        {
            this.key = key;
            this.val = val;
        }
    }

    public class LRUCache
    {
        private int capacity;
        private Dictionary<int, LRUNode> cache;
        private LRUNode left;
        private LRUNode right;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new();
            left = new LRUNode(0, 0);
            right = new LRUNode(0, 0);
            left.next = right;
            right.prev = left;
        }

        public void Remove(LRUNode node)
        {
            LRUNode prev = node.prev;
            LRUNode next = node.next;
            prev.next = next;
            next.prev = prev;
        }

        public void Insert(LRUNode node)
        {
            LRUNode prev = right.prev;
            LRUNode next = right;
            prev.next = node;
            next.prev = node;
            node.next = next;
            node.prev = prev;
        }

        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                Remove(cache[key]);
                Insert(cache[key]);
                return cache[key].val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                Remove(cache[key]);
            }

            cache[key] = new LRUNode(key, value);
            Insert(cache[key]);

            if (cache.Count > capacity)
            {
                var lru = left.next;
                Remove(lru);
                cache.Remove(lru.key);
            }
        }
    }
}
