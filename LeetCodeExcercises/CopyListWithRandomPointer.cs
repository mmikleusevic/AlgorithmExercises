namespace LeetCodeExcercises
{
    public static class CopyListWithRandomPointer
    {
        public class RandomNode
        {
            public int val;
            public RandomNode next;
            public RandomNode random;

            public RandomNode(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public static RandomNode CopyRandomList(RandomNode head)
        {
            if (head == null) return null;
            var map = new Dictionary<RandomNode, RandomNode>();
            var curr = head;
            while (curr != null)
            {
                var clone = CloneNode(curr, map);
                clone.next = CloneNode(curr.next, map);
                clone.random = CloneNode(curr.random, map);

                curr = curr.next;
            }
            return map[head];
        }

        private static RandomNode CloneNode(RandomNode node, IDictionary<RandomNode, RandomNode> map)
        {
            if (node == null) return null;
            if (map.ContainsKey(node)) return map[node];

            var clone = new RandomNode(node.val);
            map[node] = clone;
            return clone;
        }

        //public static RandomNode CopyRandomList(RandomNode head)
        //{
        //    if (head == null) return null;

        //    RandomNode cur = head;
        //    RandomNode root = new RandomNode(-1);
        //    RandomNode next = root;
        //    while (cur != null)
        //    {
        //        next.next = new RandomNode(cur.val);
        //        next = next.next;
        //        cur = cur.next;
        //    }

        //    cur = head;
        //    RandomNode start = root.next;

        //    while (start != null && cur != null)
        //    {
        //        RandomNode traverseA = head;
        //        RandomNode traverseB = root.next;
        //        if (cur.random != null)
        //        {
        //            while (traverseA != null && traverseB != null)
        //            {
        //                if (cur.random == traverseA)
        //                {
        //                    start.random = traverseB;
        //                }
        //                traverseA = traverseA.next;
        //                traverseB = traverseB.next;
        //            }
        //        }
        //        cur = cur.next;
        //        start = start.next;
        //    }

        //    return root.next;
        //}
    }
}
